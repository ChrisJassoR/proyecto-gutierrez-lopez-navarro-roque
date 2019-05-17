﻿// <auto-generated />
using System;
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190517003034_Correcciones")]
    partial class Correcciones
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("App.Models.DataBaseModel.Actividad", b =>
                {
                    b.Property<int>("actividadClave")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nombreActidad");

                    b.Property<int>("puntaje");

                    b.HasKey("actividadClave");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.ActividadAlumno", b =>
                {
                    b.Property<int>("actividadalumnoClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("alumnoId");

                    b.Property<int>("cursoactividadClave");

                    b.HasKey("actividadalumnoClave");

                    b.HasIndex("alumnoId");

                    b.HasIndex("cursoactividadClave");

                    b.ToTable("ActividadAlumnos");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Alumno", b =>
                {
                    b.Property<int>("alumnoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nombre");

                    b.HasKey("alumnoId");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Calificacion", b =>
                {
                    b.Property<int>("calificacionClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("alumnoId");

                    b.Property<bool>("aprobado");

                    b.Property<string>("cicloClave");

                    b.Property<int?>("cursoClave");

                    b.HasKey("calificacionClave");

                    b.HasIndex("alumnoId");

                    b.HasIndex("cicloClave");

                    b.HasIndex("cursoClave");

                    b.ToTable("Calificaciones");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Carrera", b =>
                {
                    b.Property<string>("carreraClave")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nombre");

                    b.HasKey("carreraClave");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Ciclo", b =>
                {
                    b.Property<string>("cicloClave")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("fin");

                    b.Property<DateTime>("inicio");

                    b.HasKey("cicloClave");

                    b.ToTable("Ciclos");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Competencia", b =>
                {
                    b.Property<int>("competenciaClave")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("competencia");

                    b.Property<int>("tipoClave");

                    b.HasKey("competenciaClave");

                    b.HasIndex("tipoClave");

                    b.ToTable("Competencias");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Curso", b =>
                {
                    b.Property<int>("cursoClave")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cicloClave");

                    b.Property<int>("materiaClave");

                    b.Property<int>("profesorId");

                    b.HasKey("cursoClave");

                    b.HasIndex("cicloClave");

                    b.HasIndex("materiaClave");

                    b.HasIndex("profesorId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.CursoActividad", b =>
                {
                    b.Property<int>("cursoactividadClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("actividadClave");

                    b.Property<int>("cursoClave");

                    b.Property<DateTime>("fecha_entrega");

                    b.HasKey("cursoactividadClave");

                    b.HasIndex("actividadClave");

                    b.HasIndex("cursoClave");

                    b.ToTable("CursoActividades");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Materia", b =>
                {
                    b.Property<int>("materiaClave")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<string>("carreraClave");

                    b.HasKey("materiaClave");

                    b.HasIndex("carreraClave");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Profesor", b =>
                {
                    b.Property<int>("profesorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nombre");

                    b.HasKey("profesorId");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Tipo", b =>
                {
                    b.Property<int>("tipoClave")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nombre");

                    b.HasKey("tipoClave");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Trabajo", b =>
                {
                    b.Property<int>("trabajoClave")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("actividadClave");

                    b.Property<int>("competenciaClave");

                    b.HasKey("trabajoClave");

                    b.HasIndex("actividadClave");

                    b.HasIndex("competenciaClave");

                    b.ToTable("Trabajos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.ActividadAlumno", b =>
                {
                    b.HasOne("App.Models.DataBaseModel.Alumno", "Alumno")
                        .WithMany("ActividadAlumnos")
                        .HasForeignKey("alumnoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.DataBaseModel.CursoActividad", "CursoActividad")
                        .WithMany("ActividadAlumnoS")
                        .HasForeignKey("cursoactividadClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Calificacion", b =>
                {
                    b.HasOne("App.Models.DataBaseModel.Alumno", "Alumno")
                        .WithMany("Calificaciones")
                        .HasForeignKey("alumnoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.DataBaseModel.Ciclo", "Ciclo")
                        .WithMany()
                        .HasForeignKey("cicloClave");

                    b.HasOne("App.Models.DataBaseModel.Curso")
                        .WithMany("Calificacion")
                        .HasForeignKey("cursoClave");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Competencia", b =>
                {
                    b.HasOne("App.Models.DataBaseModel.Tipo", "Tipo")
                        .WithMany("Competencia")
                        .HasForeignKey("tipoClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Curso", b =>
                {
                    b.HasOne("App.Models.DataBaseModel.Ciclo", "Ciclo")
                        .WithMany("Cursos")
                        .HasForeignKey("cicloClave");

                    b.HasOne("App.Models.DataBaseModel.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("materiaClave")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.DataBaseModel.Profesor", "Profesor")
                        .WithMany("Cursos")
                        .HasForeignKey("profesorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.DataBaseModel.CursoActividad", b =>
                {
                    b.HasOne("App.Models.DataBaseModel.Actividad", "Actividad")
                        .WithMany("CursoActividades")
                        .HasForeignKey("actividadClave")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.DataBaseModel.Curso", "Curso")
                        .WithMany("CursoActividades")
                        .HasForeignKey("cursoClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Materia", b =>
                {
                    b.HasOne("App.Models.DataBaseModel.Carrera", "Carrera")
                        .WithMany("Materias")
                        .HasForeignKey("carreraClave");
                });

            modelBuilder.Entity("App.Models.DataBaseModel.Trabajo", b =>
                {
                    b.HasOne("App.Models.DataBaseModel.Actividad", "Actividad")
                        .WithMany("Trabajos")
                        .HasForeignKey("actividadClave")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.DataBaseModel.Competencia", "Competencia")
                        .WithMany()
                        .HasForeignKey("competenciaClave")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
