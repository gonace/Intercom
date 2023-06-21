using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Articles
{
    public class CreateRequest : PayloadRequest
    {
        public Article Article { get; }

        public CreateRequest(Article article)
        {
            Article = article;
        }

        public override object Payload => new
        {
            title = Article.Title,
            description = Article.Description,
            body = Article.Body,
            author_id = Article.AuthorId,
            state = Article.State,
            parent_id = Article.ParentId,
            parent_type = Article.ParentType,
            translated_content = Article.TranslatedContent
        };

        public override string Uri => "data_attributes";
    }
}
