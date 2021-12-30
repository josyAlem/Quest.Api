namespace Quest.Api.Helpers.Auth
{
    public static class AuthorizationScope
    {
        public static class Cart
        {
            public const string Get = "cart:get";
            public const string Add = "cart:add";
            public const string Edit = "cart:edit";
            public const string Remove = "cart:remove";
        }

        public static class Catalog
        {
            public const string Get = "catalog:get";
            public const string Add = "catalog:add";
            public const string Edit = "catalog:edit";
            public const string Remove = "catalog:remove";
        }

        public static class Payment
        {
            public const string Get = "payment:get";
            public const string Add = "payment:add";
            public const string Edit = "payment:edit";
            public const string Remove = "payment:remove";
        }
        public static class Report
        {
            public const string View = "report:view";
        }

    }
}
