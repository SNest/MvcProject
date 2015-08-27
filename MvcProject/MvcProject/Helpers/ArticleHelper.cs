using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Domain.Entities;

namespace MvcProject.Helpers
{
    public static class ArticleHelper
    {
        public static MvcHtmlString ArticleFor(this HtmlHelper html,
            List<Article> articles, String Name)
        {
            TagBuilder br = new TagBuilder("br");

            TagBuilder hr = new TagBuilder("hr");

            TagBuilder articleSet = new TagBuilder("div");
            articleSet.InnerHtml += hr.ToString();
            articleSet.MergeAttribute("name", Name);

            TagBuilder title = new TagBuilder("h3");
            title.MergeAttribute("class", "title");

            TagBuilder text = new TagBuilder("article");
            text.MergeAttribute("class", "text");

            TagBuilder date = new TagBuilder("span");
            date.MergeAttribute("class", "date");

            TagBuilder details = new TagBuilder("a");
            details.SetInnerText("Show details");
            details.MergeAttribute("target", "blank");

            for (int i = 0; i < articles.Count; i++ )
            {
                TagBuilder articleLink = new TagBuilder("a");
                articleLink.MergeAttribute("name", "" + i);

                title.SetInnerText(articles[i].Title);

                date.SetInnerText(articles[i].Date.ToString());

                if (articles[i].Text.Length <= 200)
                {
                    text.SetInnerText(articles[i].Text);
                    
                    articleSet.InnerHtml += articleLink + title.ToString() + text + br +
                   date + hr;
                }
                else
                {
                    text.SetInnerText(articles[i].Text.Substring(0, 200) + "...");

                    details.MergeAttribute("href", "/Home/ArticleDetails/" + articles[i].Id);

                    articleSet.InnerHtml += articleLink + title.ToString() + text + br +
                   date + details + hr;
                }
            }
            return new MvcHtmlString(articleSet.ToString());
        }

        public static MvcHtmlString ArticleMenuFor(this HtmlHelper html,
            List<Article> articles, String Name)
        {
            TagBuilder hr = new TagBuilder("hr");
            hr.MergeAttribute("class", "article-hr");

            TagBuilder menu = new TagBuilder("ul");
            menu.MergeAttribute("class", "menu");
            menu.MergeAttribute("name", Name);
            menu.InnerHtml += hr.ToString();

            TagBuilder menuItem = new TagBuilder("li");
            menuItem.MergeAttribute("class", "menu-item");

            for (int i = 0; i < articles.Count; i++)
            {
                TagBuilder menuItemLink = new TagBuilder("a");
                menuItemLink.MergeAttribute("href", "#" +i);
                if (articles[i].Title.Length <= 35)
                {
                    menuItem.SetInnerText(articles[i].Title);
                }
                else
                {
                    menuItem.SetInnerText(articles[i].Title.Substring(0, 32) + "...");
                }
                           
                menuItemLink.InnerHtml = menuItem.ToString();
                menu.InnerHtml += menuItemLink.ToString(); 
            }

            menu.InnerHtml += hr.ToString();

            return new MvcHtmlString(menu.ToString());
        }
    }
}