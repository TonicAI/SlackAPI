﻿namespace SlackAPI
{
    [RequestPath("search.messages")]
    public class SearchResponseMessages : Response
    {
        public string query;
    }

    public class SearchResponseMessagesContainer
    {
        /// <summary>
        /// Can be null if used in the context of search.all
        /// Please use paging.total instead.
        /// </summary>
        public int total;
        public PaginationInformation paging;
        public ContextMessage[] matches;
    }

    public class PaginationInformation
    {
        public int count;
        public int total;
        public int page;
        public int pages;

        //These are defined for search results?  Undocumented stuff ftw? :P
        /// <summary>
        /// Undocumented. Use with care.
        /// </summary>
        public int first;
        /// <summary>
        /// Undocumented. Use with care.
        /// </summary>
        public int last;
        /// <summary>
        /// Undocumented. Use with care.
        /// </summary>
        public int page_count;
        /// <summary>
        /// Undocumented. Use with care.
        /// </summary>
        public int per_page;
        /// <summary>
        /// Undocumented. Use with care.
        /// </summary>
        public int total_count;
    }

    public enum SearchSort
    {
        not_set,
        score,
        timestamp,
        not_set_new_user
    }

    public enum SearchSortDirection
    {
        asc,
        desc
    }
}
