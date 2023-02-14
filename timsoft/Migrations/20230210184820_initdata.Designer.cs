﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using timsoft.DataBase;

#nullable disable

namespace timsoft.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230210184820_initdata")]
    partial class initdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EpreuveQuestion", b =>
                {
                    b.Property<int>("EpreuveIdEpreuve")
                        .HasColumnType("integer");

                    b.Property<int>("QuestionIdQuest")
                        .HasColumnType("integer");

                    b.HasKey("EpreuveIdEpreuve", "QuestionIdQuest");

                    b.HasIndex("QuestionIdQuest");

                    b.ToTable("REpreuveQuest", (string)null);
                });

            modelBuilder.Entity("QuestionReponse", b =>
                {
                    b.Property<int>("QuestionIdQuest")
                        .HasColumnType("integer");

                    b.Property<int>("ReponseIdReponse")
                        .HasColumnType("integer");

                    b.HasKey("QuestionIdQuest", "ReponseIdReponse");

                    b.HasIndex("ReponseIdReponse");

                    b.ToTable("ReponseQuest", (string)null);
                });

            modelBuilder.Entity("RéclamationUser", b =>
                {
                    b.Property<int>("RéclamationIdReclam")
                        .HasColumnType("integer");

                    b.Property<int>("UsersIdUser")
                        .HasColumnType("integer");

                    b.HasKey("RéclamationIdReclam", "UsersIdUser");

                    b.HasIndex("UsersIdUser");

                    b.ToTable("UserReclam", (string)null);
                });

            modelBuilder.Entity("timsoft.entities.Epreuve", b =>
                {
                    b.Property<int>("IdEpreuve")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdEpreuve"));

                    b.Property<string>("Complexité")
                        .HasColumnType("text");

                    b.Property<int>("Duree")
                        .HasColumnType("integer");

                    b.Property<string>("NomEpreuve")
                        .HasColumnType("text");

                    b.Property<int>("SommePoints")
                        .HasColumnType("integer");

                    b.Property<int>("Type_EpreuvesIdType")
                        .HasColumnType("integer");

                    b.HasKey("IdEpreuve");

                    b.HasIndex("Type_EpreuvesIdType");

                    b.ToTable("Epreuve");
                });

            modelBuilder.Entity("timsoft.entities.Invitation", b =>
                {
                    b.Property<int>("IdInv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdInv"));

                    b.Property<int>("UserIdUser")
                        .HasColumnType("integer");

                    b.Property<DateTime>("date_inv")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.HasKey("IdInv");

                    b.HasIndex("UserIdUser");

                    b.ToTable("Invitation");
                });

            modelBuilder.Entity("timsoft.entities.Question", b =>
                {
                    b.Property<int>("IdQuest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdQuest"));

                    b.Property<string>("Catégorie")
                        .HasColumnType("text");

                    b.Property<int>("Durée")
                        .HasColumnType("integer");

                    b.Property<string>("Intitule")
                        .HasColumnType("text");

                    b.Property<int>("NbRep")
                        .HasColumnType("integer");

                    b.Property<int>("Point")
                        .HasColumnType("integer");

                    b.HasKey("IdQuest");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("timsoft.entities.Réclamation", b =>
                {
                    b.Property<int>("IdReclam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdReclam"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Objet")
                        .HasColumnType("text");

                    b.HasKey("IdReclam");

                    b.ToTable("Réclamation");
                });

            modelBuilder.Entity("timsoft.entities.Reponse", b =>
                {
                    b.Property<int>("IdReponse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdReponse"));

                    b.Property<string>("Flag")
                        .HasColumnType("text");

                    b.HasKey("IdReponse");

                    b.ToTable("Reponse");
                });

            modelBuilder.Entity("timsoft.entities.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdRole"));

                    b.Property<string>("RoleName")
                        .HasColumnType("text");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            IdRole = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            IdRole = 2,
                            RoleName = "RH"
                        },
                        new
                        {
                            IdRole = 3,
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("timsoft.entities.Type_Epreuve", b =>
                {
                    b.Property<int>("IdType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdType"));

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("IdType");

                    b.ToTable("Type_Epreuve");
                });

            modelBuilder.Entity("timsoft.entities.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdUser"));

                    b.Property<string>("Nom")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prénom")
                        .HasColumnType("text");

                    b.Property<int?>("RolesIdRole")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("IdUser");

                    b.HasIndex("RolesIdRole");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("timsoft.entities.UserEpreuve", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("integer");

                    b.Property<int>("IdEpreuve")
                        .HasColumnType("integer");

                    b.Property<string>("Resultat")
                        .HasColumnType("text");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.Property<DateTime>("date_lim")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("IdUser", "IdEpreuve");

                    b.HasIndex("IdEpreuve");

                    b.ToTable("UserEpreuve");
                });

            modelBuilder.Entity("EpreuveQuestion", b =>
                {
                    b.HasOne("timsoft.entities.Epreuve", null)
                        .WithMany()
                        .HasForeignKey("EpreuveIdEpreuve")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("timsoft.entities.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionIdQuest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuestionReponse", b =>
                {
                    b.HasOne("timsoft.entities.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionIdQuest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("timsoft.entities.Reponse", null)
                        .WithMany()
                        .HasForeignKey("ReponseIdReponse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RéclamationUser", b =>
                {
                    b.HasOne("timsoft.entities.Réclamation", null)
                        .WithMany()
                        .HasForeignKey("RéclamationIdReclam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("timsoft.entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("timsoft.entities.Epreuve", b =>
                {
                    b.HasOne("timsoft.entities.Type_Epreuve", "Type_Epreuves")
                        .WithMany("Epreuve")
                        .HasForeignKey("Type_EpreuvesIdType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type_Epreuves");
                });

            modelBuilder.Entity("timsoft.entities.Invitation", b =>
                {
                    b.HasOne("timsoft.entities.User", "User")
                        .WithMany("Invitations")
                        .HasForeignKey("UserIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("timsoft.entities.User", b =>
                {
                    b.HasOne("timsoft.entities.Role", "Roles")
                        .WithMany("Users")
                        .HasForeignKey("RolesIdRole");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("timsoft.entities.UserEpreuve", b =>
                {
                    b.HasOne("timsoft.entities.Epreuve", "Epreuve")
                        .WithMany("UserEpreuves")
                        .HasForeignKey("IdEpreuve")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("timsoft.entities.User", "User")
                        .WithMany("UserEpreuves")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Epreuve");

                    b.Navigation("User");
                });

            modelBuilder.Entity("timsoft.entities.Epreuve", b =>
                {
                    b.Navigation("UserEpreuves");
                });

            modelBuilder.Entity("timsoft.entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("timsoft.entities.Type_Epreuve", b =>
                {
                    b.Navigation("Epreuve");
                });

            modelBuilder.Entity("timsoft.entities.User", b =>
                {
                    b.Navigation("Invitations");

                    b.Navigation("UserEpreuves");
                });
#pragma warning restore 612, 618
        }
    }
}
