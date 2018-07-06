using Apo.Infrastructure.Repository;
using ApoForum.Common;
using ApoForum.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ApoForum.Web.Controllers
{
    public class AdminController : BaseAdminController
    {
        // GET: Admin
      
        IUserRolesRepository _userRolesRepository;
        public AdminController(IUserRolesRepository userRolesRepository)
        {
            _userRolesRepository = userRolesRepository;
        }
        public ActionResult Index()
        {
            return View();
        }

        #region Roles
            public ActionResult Roles()
            {
                return PartialView();
            }

            [HttpGet]
            public JsonResult RolesList()
            {

                var result = ApplicationDbContext.Create().Roles.ToList();
                return Json(result, JsonRequestBehavior.AllowGet);
            }

            [HttpPost]
            public bool AddRole(string roleName)
            {
                using(ApplicationDbContext _appContext = new ApplicationDbContext())
                {
                    var result = _appContext.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = roleName });
                    try
                    {
                        _appContext.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
         

            }

            [HttpPost]
            public bool DeleteRole(string roleId)
            {
                using (var _appContext = new ApplicationDbContext())
                {
                    var result = _appContext.Roles.SingleOrDefault(c => c.Id == roleId);
                    _appContext.Roles.Remove(result);
                    try
                    {
                        _appContext.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }

            }
        #endregion


        #region Users
        public ActionResult Users()
        {
            return PartialView();
        }

        [HttpGet]
        public JsonResult UsersList()
        {
            var result = ApplicationDbContext.Create().Users.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public void addRole(string userId)
        {
            var ff = UserManager.AddToRoleAsync(userId, "Administrator");
           

        }


        [HttpGet]
        public ActionResult UserDetail(string userId)
        {
            var result = ApplicationDbContext.Create().Users.SingleOrDefault(c => c.Id == userId);
            addRole(userId);
            UserModel model = new UserModel()
            {
                PhoneNumber = result.PhoneNumber,
                UserName = result.UserName,
                Email = result.Email,
                Id = result.Id
            };   
            return PartialView(model);
        }

        [HttpPost]
        public bool UserDetail(UserModel model)
        {
                using (var _appContext = new ApplicationDbContext())
                {
                    var getUser = _appContext.Users.FirstOrDefault(c => c.Id == model.Id);
                    getUser.Email = model.Email;
                    getUser.PhoneNumber = model.PhoneNumber;
                    getUser.UserName = model.UserName;
                    _appContext.SaveChanges();
                    return true;
                }
        }

        #endregion


    }
}