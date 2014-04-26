using System;
using System.Collections.Generic;

namespace Github_Comments
{
    public class CommentModel
    {
        public CommentModel(string user, string date, string commit, Uri userUri, Uri commentUri)
        {
            User = user;
            UserUri = userUri;
            Date = date;
            Commit = commit;
            CommentUri = commentUri;
        }

        public string User { get; set; }
        public Uri UserUri { get; set; }
        public string Date { get; set; }
        public string Commit { get; set; }
        public Uri CommentUri { get; set; }
    }

    public class ViewModel
    {
        private IList<CommentModel> _commentModels;

        public IList<CommentModel> CommentModels
        {
            get
            {
                return _commentModels ?? (_commentModels = new List<CommentModel>
                {
                    new CommentModel("aknuds1", "25.04.2014", "aknuds1/chuckjs@e4bfe72d03", new Uri("http://github.com/aknuds1"),
                        new Uri("https://github.com/aknuds1/chuckjs/commit/e4bfe72d0330e0c14850c6118b92dff280f2a308#commitcomment-6132564")),
                    new CommentModel("aknuds1", "25.04.2014", "aknuds1/chuckjs@e4bfe72d03", new Uri("http://github.com/aknuds1"),
                        new Uri("https://github.com/aknuds1/chuckjs/commit/e4bfe72d0330e0c14850c6118b92dff280f2a308#commitcomment-6132570"))
                });
            }
            set
            {
                _commentModels = value;
            }
        }
    }
}