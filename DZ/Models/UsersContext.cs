using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ.Models
{ 
public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Otryadnik> Otryadniks { get; set; } 
    public DbSet<RoleModel> RoleModels { get; set; }
    public DbSet<BrigadesEventModel> BrigadesEventModels { get; set; }
    public DbSet<DetachmentsModel> DetachmentsModels { get; set; }
    public DbSet<EventModel> EventModels { get; set; }
    public DbSet<PositionsModel> PositionsModels { get; set; }
    public DbSet<ProfileModel> ProfileModels { get; set; }
    public DbSet<UniversityModel> UniversityModels { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
: base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminLogin = "admin";
            string adminPassword = "admin";

            string stroy = "Строительный";
            string ped = "Педагогический";
            string prof = "Профильный";
            string sop = "Проводниковый";






            // создаем роли
            RoleModel adminRole = new RoleModel { Id = 1, Name = adminRoleName };
            RoleModel userRole = new RoleModel { Id = 2, Name = userRoleName };

            ProfileModel pedmod = new ProfileModel { Id = 1, Name = ped };
            ProfileModel profmod = new ProfileModel { Id = 2, Name = prof };
            ProfileModel sopmod = new ProfileModel { Id = 3, Name = sop };
            ProfileModel stroymod = new ProfileModel { Id = 4, Name = stroy };

            UniversityModel urfu = new UniversityModel { Id = 1, Name = "УрФУ" };
            UniversityModel urgppu = new UniversityModel { Id = 2, Name = "УрГППУ" };
            UniversityModel sinh = new UniversityModel { Id = 3, Name = "УрГЭУ СИНХ" };
            UniversityModel lesteh = new UniversityModel { Id = 4, Name = "ЛесТех" };

            PositionsModel kmdr = new PositionsModel { Id = 1, PositionName = "Командир" };
            PositionsModel kmsr = new PositionsModel { Id = 2, PositionName = "Комиссар" };
            PositionsModel master = new PositionsModel { Id = 3, PositionName = "Мастер" };
            PositionsModel medik = new PositionsModel { Id = 4, PositionName = "Медик" };
            PositionsModel zavhoz = new PositionsModel { Id = 5, PositionName = "Завхоз" };
            PositionsModel boec = new PositionsModel { Id = 6, PositionName = "Боец" };
            PositionsModel kandidat = new PositionsModel { Id = 7, PositionName = "Кандидат" };
            PositionsModel starushka = new PositionsModel { Id = 8, PositionName = "Старушка" };

            EventModel spevka = new EventModel { Id = 1, Name = "Первая спевка", EndDate = new DateTime(2021, 9, 9, 0,0,0), StartDate = new DateTime(2021, 9, 9, 0,0,0), Description = "Общая спевка отрядов после целины" };
            EventModel mariinka = new EventModel { Id = 2, Name = "Фестиваль танцев \"Мариинка\"", EndDate = new DateTime(2021, 11, 30, 0, 0, 0), StartDate = new DateTime(2021, 11, 29, 0, 0, 0), Description = "Фестиваль танцев" };
            EventModel zz = new EventModel { Id = 3, Name = "Зимняя Знаменка", EndDate = new DateTime(2021, 02, 23, 0, 0, 0), StartDate = new DateTime(2021, 02, 23, 0, 0, 0), Description = "Фестиваль песен и танцев на льду" };
            EventModel kvn = new EventModel { Id = 4, Name = "КВН", EndDate = new DateTime(2021, 04, 22, 0, 0, 0), StartDate = new DateTime(2021, 04, 20, 0, 0, 0), Description = "КВН среди отрядов" };
            EventModel hokkey = new EventModel { Id = 5, Name = "Хоккей", EndDate = new DateTime(2021, 03, 08, 0, 0, 0), StartDate = new DateTime(2021, 03, 08, 0, 0, 0), Description = "Соревнования по хоккею среди женских и мужских отрядов" };
            EventModel star = new EventModel { Id = 6, Name = "Звездник", EndDate = new DateTime(2021, 05, 24, 0, 0, 0), StartDate = new DateTime(2021, 05, 24, 0, 0, 0), Description = "Фестиваль уличных танцев" };
            // и юзера
            User adminUser = new User { Id = 1, Email = adminLogin, Password = adminPassword, RoleId = adminRole.Id};

            modelBuilder.Entity<RoleModel>().HasData(new RoleModel[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel[] {pedmod, profmod, sopmod, stroymod });

            modelBuilder.Entity<UniversityModel>().HasData(new UniversityModel[] { urfu, urgppu, sinh, lesteh });

            modelBuilder.Entity<PositionsModel>().HasData(new PositionsModel[] { kmdr, kmsr, master, medik, zavhoz, boec, kandidat, starushka });

            modelBuilder.Entity<EventModel>().HasData(new EventModel[] { spevka, mariinka, zz, kvn, hokkey, star });
            base.OnModelCreating(modelBuilder);

        }
        }
    }
