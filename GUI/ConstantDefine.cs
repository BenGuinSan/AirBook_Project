using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class ConstantDefine
    {
        public enum siteName
        {
            SIGNIN,
            SIGNUP_EUC,
            BUY_TICKET_EUC,
            PROMO_EUC,
            ACCOUNT_EUC,
            MYTICKET_EUC,
            STATISTIC_AD,
            TICKET_AD,
            PROMO_AD,
            FLIGHT_AD,
            AIRLINE_AD,
            AIRLINE_PLANE_AD,
            AIRPORT_AD,
            ACCOUNT_AD,
            ACCOUNT_AUTH_AD,
            FEATURE_AD
        }

        public static Dictionary<siteName, string> siteNameDict = new Dictionary<siteName, string>()
        {
            { siteName.SIGNIN, "Đăng nhập" },
            { siteName.SIGNUP_EUC, "Đăng ký"},
            { siteName.BUY_TICKET_EUC, "Mua vé" },
            { siteName.PROMO_EUC, "Khuyến mãi" },
            { siteName.ACCOUNT_EUC, "Thông tin của tôi" },
            { siteName.MYTICKET_EUC, "Vé của tôi" },
            { siteName.STATISTIC_AD, "Thống kê" },
            { siteName.TICKET_AD, "Quản lý vé" },
            { siteName.PROMO_AD, "Quản lý chương trình KM" },
            { siteName.FLIGHT_AD, "Quản lý chuyến bay" },
            { siteName.AIRLINE_AD, "Quản lý hãng bay" },
            { siteName.AIRLINE_PLANE_AD, "Chi tiết hãng bay" },
            { siteName.AIRPORT_AD, "Quản lý sân bay"},
            { siteName.ACCOUNT_AD, "Quản lý tài khoản" },
            { siteName.ACCOUNT_AUTH_AD, "Quản lý tài khoản" },
            { siteName.FEATURE_AD, "Quản lý chức năng" }
        };
    }
}
