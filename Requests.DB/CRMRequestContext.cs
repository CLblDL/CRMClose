using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class CRMRequestContext : DbContext
    {
        public CRMRequestContext()
        {
        }

        public CRMRequestContext(DbContextOptions<CRMRequestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chat> Chat { get; set; }
        public virtual DbSet<ConditionTheUser> ConditionTheUser { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<IdentetyTown> IdentetyTown { get; set; }
        public virtual DbSet<ListMessage> ListMessage { get; set; }
        public virtual DbSet<ListRequestsAtUser> ListRequestsAtUser { get; set; }
        public virtual DbSet<ListUserChats> ListUserChats { get; set; }
        public virtual DbSet<LoginAndpasswordUsers> LoginAndpasswordUsers { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<RequestCondition> RequestCondition { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<RequestsAddress> RequestsAddress { get; set; }
        public virtual DbSet<RequestsCategory> RequestsCategory { get; set; }
        public virtual DbSet<RequestsUrgency> RequestsUrgency { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<Town> Town { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserCategory> UserCategory { get; set; }
        public virtual DbSet<UserRoleInrequest> UserRoleInrequest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CRMRequest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>(entity =>
            {
                entity.Property(e => e.ChatId).HasColumnName("chatID");

                entity.Property(e => e.ChatDateCreate)
                    .HasColumnName("chatDateCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChatInterlocutor).HasColumnName("chatInterlocutor");
            });

            modelBuilder.Entity<ConditionTheUser>(entity =>
            {
                entity.Property(e => e.ConditionTheUserId)
                    .HasColumnName("conditionTheUserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OnditionTheUserName)
                    .IsRequired()
                    .HasColumnName("onditionTheUserName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartamentName)
                    .IsRequired()
                    .HasColumnName("departamentName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IdentetyTown>(entity =>
            {
                entity.Property(e => e.IdentetyTownId).HasColumnName("identetyTownID");

                entity.Property(e => e.NameTownId).HasColumnName("nameTownID");

                entity.Property(e => e.TownIndex).HasColumnName("townIndex");

                entity.HasOne(d => d.NameTown)
                    .WithMany(p => p.IdentetyTown)
                    .HasForeignKey(d => d.NameTownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdentetyTown_Town");
            });

            modelBuilder.Entity<ListMessage>(entity =>
            {
                entity.Property(e => e.ListMessageId).HasColumnName("listMessageID");

                entity.Property(e => e.ListMessageChatIdFk).HasColumnName("listMessageChatID(fk)");

                entity.Property(e => e.ListMessageMessageIdFk).HasColumnName("listMessageMessageID(fk)");

                entity.HasOne(d => d.ListMessageChatIdFkNavigation)
                    .WithMany(p => p.ListMessage)
                    .HasForeignKey(d => d.ListMessageChatIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListMessage_Chat");

                entity.HasOne(d => d.ListMessageMessageIdFkNavigation)
                    .WithMany(p => p.ListMessage)
                    .HasForeignKey(d => d.ListMessageMessageIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListMessage_Messages");
            });

            modelBuilder.Entity<ListRequestsAtUser>(entity =>
            {
                entity.Property(e => e.ListRequestsAtUserId).HasColumnName("listRequestsAtUserID");

                entity.Property(e => e.ListRequestsAtUserRequestIdFk).HasColumnName("listRequestsAtUserRequestID(fk)");

                entity.Property(e => e.ListRequestsAtUserUserIdFk).HasColumnName("listRequestsAtUserUserID(fk)");

                entity.Property(e => e.ListRequestsAtUserUserRoleFk).HasColumnName("listRequestsAtUserUserRole(fk)");

                entity.HasOne(d => d.ListRequestsAtUserRequestIdFkNavigation)
                    .WithMany(p => p.ListRequestsAtUser)
                    .HasForeignKey(d => d.ListRequestsAtUserRequestIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListRequestsAtUser_Requests");

                entity.HasOne(d => d.ListRequestsAtUserUserIdFkNavigation)
                    .WithMany(p => p.ListRequestsAtUser)
                    .HasForeignKey(d => d.ListRequestsAtUserUserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListRequestsAtUser_User");

                entity.HasOne(d => d.ListRequestsAtUserUserRoleFkNavigation)
                    .WithMany(p => p.ListRequestsAtUser)
                    .HasForeignKey(d => d.ListRequestsAtUserUserRoleFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListRequestsAtUser_UserRoleINRequest");
            });

            modelBuilder.Entity<ListUserChats>(entity =>
            {
                entity.HasKey(e => e.ListUserChatId);

                entity.Property(e => e.ListUserChatId).HasColumnName("listUserChatID");

                entity.Property(e => e.ListUserChatChatId).HasColumnName("listUserChatChatID");

                entity.Property(e => e.ListUserChatUserId).HasColumnName("listUserChatUserID");

                entity.HasOne(d => d.ListUserChatChat)
                    .WithMany(p => p.ListUserChats)
                    .HasForeignKey(d => d.ListUserChatChatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListUserChats_Chat");

                entity.HasOne(d => d.ListUserChatUser)
                    .WithMany(p => p.ListUserChats)
                    .HasForeignKey(d => d.ListUserChatUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListUserChats_User");
            });

            modelBuilder.Entity<LoginAndpasswordUsers>(entity =>
            {
                entity.ToTable("LoginANDPasswordUsers");

                entity.Property(e => e.LoginAndpasswordUsersId).HasColumnName("LoginANDPasswordUsersID");

                entity.Property(e => e.LoginUser)
                    .IsRequired()
                    .HasColumnName("loginUser")
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordUser)
                    .IsRequired()
                    .HasColumnName("passwordUser")
                    .HasMaxLength(66);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.Property(e => e.MessagesId).HasColumnName("messagesID");

                entity.Property(e => e.MessageCondition).HasColumnName("messageCondition");

                entity.Property(e => e.MessageContent)
                    .IsRequired()
                    .HasColumnName("messageContent")
                    .HasMaxLength(500);

                entity.Property(e => e.MessageDateCreate)
                    .HasColumnName("messageDateCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SenderId).HasColumnName("senderID");
            });

            modelBuilder.Entity<RequestCondition>(entity =>
            {
                entity.Property(e => e.RequestConditionId).HasColumnName("requestConditionID");

                entity.Property(e => e.RequestConditionName)
                    .IsRequired()
                    .HasColumnName("requestConditionName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.Property(e => e.RequestsId).HasColumnName("requestsID");

                entity.Property(e => e.RequestConditionIdFk).HasColumnName("requestConditionID(fk)");

                entity.Property(e => e.RequestScore).HasColumnName("requestScore");

                entity.Property(e => e.RequestsAddressIdFk).HasColumnName("requestsAddressID(fk)");

                entity.Property(e => e.RequestsCabinetNumber).HasColumnName("requestsCabinetNumber");

                entity.Property(e => e.RequestsCategoryIdFk).HasColumnName("requestsCategoryID(fk)");

                entity.Property(e => e.RequestsChatIdFk).HasColumnName("requestsChatID(fk)");

                entity.Property(e => e.RequestsDescription)
                    .IsRequired()
                    .HasColumnName("requestsDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.RequestsName)
                    .IsRequired()
                    .HasColumnName("requestsName")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestsUrgencyIdFk).HasColumnName("requestsUrgencyID(fk)");

                entity.HasOne(d => d.RequestConditionIdFkNavigation)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.RequestConditionIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_RequestCondition");

                entity.HasOne(d => d.RequestsAddressIdFkNavigation)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.RequestsAddressIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_RequestsAddress");

                entity.HasOne(d => d.RequestsCategoryIdFkNavigation)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.RequestsCategoryIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_RequestsCategory");

                entity.HasOne(d => d.RequestsChatIdFkNavigation)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.RequestsChatIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_Chat");

                entity.HasOne(d => d.RequestsUrgencyIdFkNavigation)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.RequestsUrgencyIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_RequestsUrgency");
            });

            modelBuilder.Entity<RequestsAddress>(entity =>
            {
                entity.Property(e => e.RequestsAddressId).HasColumnName("requestsAddressID");

                entity.Property(e => e.RequestAdressBuilding)
                    .IsRequired()
                    .HasColumnName("requestAdressBuilding")
                    .HasMaxLength(10);

                entity.Property(e => e.RequestAdressStreetFk).HasColumnName("requestAdressStreet(fk)");

                entity.Property(e => e.RequestAsressNumberHouse).HasColumnName("requestAsressNumberHouse");

                entity.Property(e => e.RequestsAdressTownFk).HasColumnName("requestsAdressTown(fk)");

                entity.HasOne(d => d.RequestAdressStreetFkNavigation)
                    .WithMany(p => p.RequestsAddress)
                    .HasForeignKey(d => d.RequestAdressStreetFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestsAddress_Street");

                entity.HasOne(d => d.RequestsAdressTownFkNavigation)
                    .WithMany(p => p.RequestsAddress)
                    .HasForeignKey(d => d.RequestsAdressTownFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestsAddress_IdentetyTown");
            });

            modelBuilder.Entity<RequestsCategory>(entity =>
            {
                entity.Property(e => e.RequestsCategoryId).HasColumnName("requestsCategoryID");

                entity.Property(e => e.RequestsCategoryName)
                    .IsRequired()
                    .HasColumnName("requestsCategoryName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RequestsUrgency>(entity =>
            {
                entity.Property(e => e.RequestsUrgencyId).HasColumnName("requestsUrgencyID");

                entity.Property(e => e.RequestsUrgencyName)
                    .HasColumnName("requestsUrgencyName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Street>(entity =>
            {
                entity.Property(e => e.StreetId).HasColumnName("streetID");

                entity.Property(e => e.StreetName)
                    .IsRequired()
                    .HasColumnName("streetName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.Property(e => e.TownId).HasColumnName("townID");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasColumnName("townName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserCategoryFk).HasColumnName("userCategory(fk)");

                entity.Property(e => e.UserConditionFk).HasColumnName("userCondition(fk)");

                entity.Property(e => e.UserDateCreate)
                    .HasColumnName("userDateCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserDepartamentFk).HasColumnName("userDepartament(fk)");

                entity.Property(e => e.UserLoginAndpasswordFk).HasColumnName("userLoginANDPassword(fk)");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName")
                    .HasMaxLength(50);

                entity.Property(e => e.UserNumberPhone)
                    .IsRequired()
                    .HasColumnName("userNumberPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPatranymic)
                    .IsRequired()
                    .HasColumnName("userPatranymic")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSurname)
                    .IsRequired()
                    .HasColumnName("userSurname")
                    .HasMaxLength(50);

                entity.HasOne(d => d.UserCategoryFkNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserCategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserCategory");

                entity.HasOne(d => d.UserConditionFkNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserConditionFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_ConditionTheUser");

                entity.HasOne(d => d.UserDepartamentFkNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserDepartamentFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Department");

                entity.HasOne(d => d.UserLoginAndpasswordFkNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserLoginAndpasswordFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_LoginANDPasswordUsers");
            });

            modelBuilder.Entity<UserCategory>(entity =>
            {
                entity.Property(e => e.UserCategoryId).HasColumnName("userCategoryID");

                entity.Property(e => e.UserCategoryName)
                    .IsRequired()
                    .HasColumnName("userCategoryName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserRoleInrequest>(entity =>
            {
                entity.ToTable("UserRoleINRequest");

                entity.Property(e => e.UserRoleInrequestId).HasColumnName("userRoleINRequestID");

                entity.Property(e => e.UserRoleInrequestName)
                    .IsRequired()
                    .HasColumnName("userRoleINRequestName")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
