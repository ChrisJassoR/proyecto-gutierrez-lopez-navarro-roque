using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ActividadAlumnos",
                columns: table => new
                {
                    actividadalumnoClave = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadAlumnos", x => x.actividadalumnoClave);
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    calificacionClave = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.calificacionClave);
                });

            migrationBuilder.CreateTable(
                name: "Trabajos",
                columns: table => new
                {
                    trabajoClave = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajos", x => x.trabajoClave);
                });

            migrationBuilder.CreateTable(
                name: "CursoActividades",
                columns: table => new
                {
                    cursoactividadClave = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    actividadalumnoClave = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoActividades", x => x.cursoactividadClave);
                    table.ForeignKey(
                        name: "FK_CursoActividades_ActividadAlumnos_actividadalumnoClave",
                        column: x => x.actividadalumnoClave,
                        principalTable: "ActividadAlumnos",
                        principalColumn: "actividadalumnoClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    alumnoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    calificacionClave = table.Column<int>(nullable: false),
                    actividadalumnoClave = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.alumnoId);
                    table.ForeignKey(
                        name: "FK_Alumnos_ActividadAlumnos_actividadalumnoClave",
                        column: x => x.actividadalumnoClave,
                        principalTable: "ActividadAlumnos",
                        principalColumn: "actividadalumnoClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alumnos_Calificaciones_calificacionClave",
                        column: x => x.calificacionClave,
                        principalTable: "Calificaciones",
                        principalColumn: "calificacionClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competencias",
                columns: table => new
                {
                    competenciaClave = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    competencia = table.Column<string>(nullable: true),
                    trabajoClave = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencias", x => x.competenciaClave);
                    table.ForeignKey(
                        name: "FK_Competencias_Trabajos_trabajoClave",
                        column: x => x.trabajoClave,
                        principalTable: "Trabajos",
                        principalColumn: "trabajoClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    actividadClave = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombreActidad = table.Column<string>(nullable: true),
                    puntaje = table.Column<int>(nullable: false),
                    trabajoClave = table.Column<int>(nullable: false),
                    cursoactividadClave = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.actividadClave);
                    table.ForeignKey(
                        name: "FK_Actividades_CursoActividades_cursoactividadClave",
                        column: x => x.cursoactividadClave,
                        principalTable: "CursoActividades",
                        principalColumn: "cursoactividadClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actividades_Trabajos_trabajoClave",
                        column: x => x.trabajoClave,
                        principalTable: "Trabajos",
                        principalColumn: "trabajoClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    cursoClave = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    calificacionClave = table.Column<int>(nullable: false),
                    cursoactividadClave = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.cursoClave);
                    table.ForeignKey(
                        name: "FK_Cursos_Calificaciones_calificacionClave",
                        column: x => x.calificacionClave,
                        principalTable: "Calificaciones",
                        principalColumn: "calificacionClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cursos_CursoActividades_cursoactividadClave",
                        column: x => x.cursoactividadClave,
                        principalTable: "CursoActividades",
                        principalColumn: "cursoactividadClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    tipoClave = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    competenciaClave = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.tipoClave);
                    table.ForeignKey(
                        name: "FK_Tipos_Competencias_competenciaClave",
                        column: x => x.competenciaClave,
                        principalTable: "Competencias",
                        principalColumn: "competenciaClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciclos",
                columns: table => new
                {
                    cicloClave = table.Column<string>(nullable: false),
                    inicio = table.Column<DateTime>(nullable: false),
                    fin = table.Column<DateTime>(nullable: false),
                    cursoClave = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciclos", x => x.cicloClave);
                    table.ForeignKey(
                        name: "FK_Ciclos_Cursos_cursoClave",
                        column: x => x.cursoClave,
                        principalTable: "Cursos",
                        principalColumn: "cursoClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    materiaClave = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Cursoclave = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.materiaClave);
                    table.ForeignKey(
                        name: "FK_Materias_Cursos_Cursoclave",
                        column: x => x.Cursoclave,
                        principalTable: "Cursos",
                        principalColumn: "cursoClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    profesorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    CursoClave = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.profesorId);
                    table.ForeignKey(
                        name: "FK_Profesores_Cursos_CursoClave",
                        column: x => x.CursoClave,
                        principalTable: "Cursos",
                        principalColumn: "cursoClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    carreraClave = table.Column<string>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    materiaClave = table.Column<int>(nullable: false),
                    materiaClave1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.carreraClave);
                    table.ForeignKey(
                        name: "FK_Carreras_Materias_materiaClave1",
                        column: x => x.materiaClave1,
                        principalTable: "Materias",
                        principalColumn: "materiaClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_cursoactividadClave",
                table: "Actividades",
                column: "cursoactividadClave");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_trabajoClave",
                table: "Actividades",
                column: "trabajoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_actividadalumnoClave",
                table: "Alumnos",
                column: "actividadalumnoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_calificacionClave",
                table: "Alumnos",
                column: "calificacionClave");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_materiaClave1",
                table: "Carreras",
                column: "materiaClave1");

            migrationBuilder.CreateIndex(
                name: "IX_Ciclos_cursoClave",
                table: "Ciclos",
                column: "cursoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Competencias_trabajoClave",
                table: "Competencias",
                column: "trabajoClave");

            migrationBuilder.CreateIndex(
                name: "IX_CursoActividades_actividadalumnoClave",
                table: "CursoActividades",
                column: "actividadalumnoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_calificacionClave",
                table: "Cursos",
                column: "calificacionClave");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_cursoactividadClave",
                table: "Cursos",
                column: "cursoactividadClave");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_Cursoclave",
                table: "Materias",
                column: "Cursoclave");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_CursoClave",
                table: "Profesores",
                column: "CursoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_competenciaClave",
                table: "Tipos",
                column: "competenciaClave");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Ciclos");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Competencias");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Trabajos");

            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropTable(
                name: "CursoActividades");

            migrationBuilder.DropTable(
                name: "ActividadAlumnos");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);
        }
    }
}
