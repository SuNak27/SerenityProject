
namespace MVC
{
    public static class Views
    {
        public static class Administration
        {
            public static class Language
            {
                public const string LanguageIndex = "~/Modules/Administration/Language/LanguageIndex.cshtml";
            }

            public static class Role
            {
                public const string RoleIndex = "~/Modules/Administration/Role/RoleIndex.cshtml";
            }

            public static class Translation
            {
                public const string TranslationIndex = "~/Modules/Administration/Translation/TranslationIndex.cshtml";
            }

            public static class User
            {
                public const string CetakKartuDetailReport = "~/Modules/Administration/User/CetakKartuDetailReport.cshtml";
                public const string UserIndex = "~/Modules/Administration/User/UserIndex.cshtml";
            }

        }

        public static class Common
        {
            public static class Dashboard
            {
                public const string DashboardIndex = "~/Modules/Common/Dashboard/DashboardIndex.cshtml";
            }
        }

        public static class Errors
        {
            public const string AccessDenied = "~/Views/Errors/AccessDenied.cshtml";
            public const string ValidationError = "~/Views/Errors/ValidationError.cshtml";
        }

        public static class Membership
        {
            public static class Account
            {
                public const string AccountLogin = "~/Modules/Membership/Account/AccountLogin.cshtml";
                public static class ChangePassword
                {
                    public const string AccountChangePassword = "~/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml";
                }

                public static class ForgotPassword
                {
                    public const string AccountForgotPassword = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml";
                }

                public static class ResetPassword
                {
                    public const string AccountResetPassword = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.cshtml";
                    public const string AccountResetPasswordEmail = "~/Modules/Membership/Account/ResetPassword/AccountResetPasswordEmail.cshtml";
                }

                public static class SignUp
                {
                    public const string AccountActivateEmail = "~/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml";
                    public const string AccountSignUp = "~/Modules/Membership/Account/SignUp/AccountSignUp.cshtml";
                }
            }

        }

        public static class Perpustakaan
        {
            public static class Buku
            {
                public const string BukuIndex = "~/Modules/Perpustakaan/Buku/BukuIndex.cshtml";
            }

            public static class Kategori
            {
                public const string KategoriIndex = "~/Modules/Perpustakaan/Kategori/KategoriIndex.cshtml";
            }

            public static class Peminjaman
            {
                public const string PeminjamanDetailReport = "~/Modules/Perpustakaan/Peminjaman/PeminjamanDetailReport.cshtml";
                public const string PeminjamanIndex = "~/Modules/Perpustakaan/Peminjaman/PeminjamanIndex.cshtml";
                public const string PengembalianIndex = "~/Modules/Perpustakaan/Peminjaman/PengembalianIndex.cshtml";
            }

            public static class Rak
            {
                public const string RakIndex = "~/Modules/Perpustakaan/Rak/RakIndex.cshtml";
            }

            public static class Status
            {
                public const string StatusIndex = "~/Modules/Perpustakaan/Status/StatusIndex.cshtml";
            }
        }

        public static class Shared
        {
            public const string _Layout = "~/Views/Shared/_Layout.cshtml";
            public const string _LayoutHead = "~/Views/Shared/_LayoutHead.cshtml";
            public const string _LayoutNoNavigation = "~/Views/Shared/_LayoutNoNavigation.cshtml";
            public const string _Sidebar = "~/Views/Shared/_Sidebar.cshtml";
            public const string Error = "~/Views/Shared/Error.cshtml";
        }

    }
}
