using MyBlog.IRepository;
using MyBlog.IService;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YY_Model;

namespace Myblog.Service
{
    public class UserInfoService : BaseService<UserInfo>, IUserInfoService
    {
        private readonly IUserInfoRepository _iUserInfoRepository;

        public UserInfoService(IUserInfoRepository iUserInfoRepository)
        {
            base._iBaseRepository = iUserInfoRepository;
            _iUserInfoRepository = iUserInfoRepository;
        }
    }
}
