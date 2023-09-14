﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace SRUNPE.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Acudiente", b =>
                {
                    b.Property<Guid>("AcudienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroIdentificacion")
                        .HasColumnType("int");

                    b.Property<string>("Ocupacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelacionConEstudiante")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AcudienteId");

                    b.ToTable("Acudiente");

                    b.HasData(
                        new
                        {
                            AcudienteId = new Guid("9c35e92e-f81f-4a1e-836c-41fb42a7e747"),
                            Apellidos = "Pérez",
                            CorreoElectronico = "maria.perez@email.com",
                            Estado = true,
                            EstadoCivil = "Casada",
                            FechaNacimiento = new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRegistro = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(531),
                            Genero = "Femenino",
                            Nombres = "María",
                            NumeroIdentificacion = 12345,
                            Ocupacion = "Ingeniera",
                            RelacionConEstudiante = "Madre"
                        },
                        new
                        {
                            AcudienteId = new Guid("cd09b4cf-b30f-434e-9d7e-740755a8422b"),
                            Apellidos = "González",
                            CorreoElectronico = "juan.gonzalez@email.com",
                            Estado = true,
                            EstadoCivil = "Soltero",
                            FechaNacimiento = new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRegistro = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(534),
                            Genero = "Masculino",
                            Nombres = "Juan",
                            NumeroIdentificacion = 67890,
                            Ocupacion = "Abogado",
                            RelacionConEstudiante = "Padre"
                        },
                        new
                        {
                            AcudienteId = new Guid("f6d8842e-ceef-44fe-98eb-60b11cdb44d0"),
                            Apellidos = "López",
                            CorreoElectronico = "ana.lopez@email.com",
                            Estado = true,
                            EstadoCivil = "Divorciada",
                            FechaNacimiento = new DateTime(1990, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRegistro = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(536),
                            Genero = "Femenino",
                            Nombres = "Ana",
                            NumeroIdentificacion = 54321,
                            Ocupacion = "Médica",
                            RelacionConEstudiante = "Tutor Legal"
                        },
                        new
                        {
                            AcudienteId = new Guid("342b7f2f-dcdc-456e-a0f5-2e9a19a15945"),
                            Apellidos = "Martínez",
                            CorreoElectronico = "pedro.martinez@email.com",
                            Estado = true,
                            EstadoCivil = "Casado",
                            FechaNacimiento = new DateTime(1988, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRegistro = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(538),
                            Genero = "Masculino",
                            Nombres = "Pedro",
                            NumeroIdentificacion = 98765,
                            Ocupacion = "Profesor",
                            RelacionConEstudiante = "Padre"
                        },
                        new
                        {
                            AcudienteId = new Guid("5b405adf-f5c0-4c7b-8432-f0ae6bd98e03"),
                            Apellidos = "Sánchez",
                            CorreoElectronico = "luis.sanchez@email.com",
                            Estado = true,
                            EstadoCivil = "Casado",
                            FechaNacimiento = new DateTime(1972, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRegistro = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(541),
                            Genero = "Masculino",
                            Nombres = "Luis",
                            NumeroIdentificacion = 13579,
                            Ocupacion = "Contador",
                            RelacionConEstudiante = "Padre"
                        },
                        new
                        {
                            AcudienteId = new Guid("68edddb3-d75e-4c8e-a38f-5f32d8493372"),
                            Apellidos = "Rodríguez",
                            CorreoElectronico = "carlos.rodriguez@email.com",
                            Estado = true,
                            EstadoCivil = "Soltero",
                            FechaNacimiento = new DateTime(1985, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRegistro = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(545),
                            Genero = "Masculino",
                            Nombres = "Carlos",
                            NumeroIdentificacion = 24680,
                            Ocupacion = "Ingeniero Civil",
                            RelacionConEstudiante = "Tío"
                        },
                        new
                        {
                            AcudienteId = new Guid("5d59c8c9-8b62-41e7-937e-0a1921d259c7"),
                            Apellidos = "Gómez",
                            CorreoElectronico = "laura.gomez@email.com",
                            Estado = true,
                            EstadoCivil = "Divorciada",
                            FechaNacimiento = new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRegistro = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(547),
                            Genero = "Femenino",
                            Nombres = "Laura",
                            NumeroIdentificacion = 86420,
                            Ocupacion = "Médica",
                            RelacionConEstudiante = "Madre"
                        },
                        new
                        {
                            AcudienteId = new Guid("a3993809-24cf-487f-a2f5-b4b278172693"),
                            Apellidos = "Hernández",
                            CorreoElectronico = "andres.hernandez@email.com",
                            Estado = true,
                            EstadoCivil = "Casado",
                            FechaNacimiento = new DateTime(1979, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRegistro = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(549),
                            Genero = "Masculino",
                            Nombres = "Andrés",
                            NumeroIdentificacion = 97531,
                            Ocupacion = "Arquitecto",
                            RelacionConEstudiante = "Padrino"
                        },
                        new
                        {
                            AcudienteId = new Guid("e73fa287-9f93-436d-a345-32063ed2fb59"),
                            Apellidos = "Díaz",
                            CorreoElectronico = "sofia.diaz@email.com",
                            Estado = true,
                            EstadoCivil = "Soltera",
                            FechaNacimiento = new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRegistro = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(551),
                            Genero = "Femenino",
                            Nombres = "Sofía",
                            NumeroIdentificacion = 75319,
                            Ocupacion = "Profesora",
                            RelacionConEstudiante = "Tía"
                        },
                        new
                        {
                            AcudienteId = new Guid("50b0b0e2-3bfc-4417-8349-e1ee43a9904b"),
                            Apellidos = "Luna",
                            CorreoElectronico = "roberto.luna@email.com",
                            Estado = true,
                            EstadoCivil = "Viudo",
                            FechaNacimiento = new DateTime(1970, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRegistro = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(553),
                            Genero = "Masculino",
                            Nombres = "Roberto",
                            NumeroIdentificacion = 10293,
                            Ocupacion = "Jubilado",
                            RelacionConEstudiante = "Abuelo"
                        });
                });

            modelBuilder.Entity("Entities.Models.CandidatoEstudiante", b =>
                {
                    b.Property<Guid>("CandidatoEstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("TipoPersona")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidatoEstudianteId");

                    b.ToTable("CandidatoEstudiantes");

                    b.HasData(
                        new
                        {
                            CandidatoEstudianteId = new Guid("20e33cc5-82f9-45f1-9d40-5c92a5b6c5d3"),
                            Apellido = "Acuña",
                            FechaNacimiento = new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Axl",
                            TipoPersona = "Estudiante"
                        },
                        new
                        {
                            CandidatoEstudianteId = new Guid("983b7cb3-a514-4db3-bac8-a28386d33f5a"),
                            Apellido = "Castro",
                            FechaNacimiento = new DateTime(1990, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Juan",
                            TipoPersona = "Estudiante"
                        },
                        new
                        {
                            CandidatoEstudianteId = new Guid("257a9c55-8e1e-41ef-8d55-45bb568e5972"),
                            Apellido = "Sánchez",
                            FechaNacimiento = new DateTime(1987, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Carlos",
                            TipoPersona = "Estudiante"
                        },
                        new
                        {
                            CandidatoEstudianteId = new Guid("c0a0888f-59fd-4578-8dd5-903505548e6c"),
                            Apellido = "López",
                            FechaNacimiento = new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Laura",
                            TipoPersona = "Estudiante"
                        },
                        new
                        {
                            CandidatoEstudianteId = new Guid("a7acbe46-b834-408f-8e53-f3a43de930fe"),
                            Apellido = "Ramírez",
                            FechaNacimiento = new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Pedro",
                            TipoPersona = "Estudiante"
                        },
                        new
                        {
                            CandidatoEstudianteId = new Guid("05bd4290-441c-47c3-a4d4-b9e02e89099f"),
                            Apellido = "Martínez",
                            FechaNacimiento = new DateTime(1993, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Ana",
                            TipoPersona = "Estudiante"
                        },
                        new
                        {
                            CandidatoEstudianteId = new Guid("0fff11ac-ba5c-479a-9318-37f3105fd505"),
                            Apellido = "Fernández",
                            FechaNacimiento = new DateTime(1989, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Roberto",
                            TipoPersona = "Estudiante"
                        },
                        new
                        {
                            CandidatoEstudianteId = new Guid("26f1006d-bd44-4f4f-bf13-ae3d600a8304"),
                            Apellido = "Gómez",
                            FechaNacimiento = new DateTime(1996, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Isabel",
                            TipoPersona = "Estudiante"
                        },
                        new
                        {
                            CandidatoEstudianteId = new Guid("fccf74e2-8329-4e38-89f1-4a4e46731ca1"),
                            Apellido = "Díaz",
                            FechaNacimiento = new DateTime(1991, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Francisco",
                            TipoPersona = "Estudiante"
                        },
                        new
                        {
                            CandidatoEstudianteId = new Guid("5f42e233-0b6c-446d-93c8-9a2d506a4a51"),
                            Apellido = "Hernández",
                            FechaNacimiento = new DateTime(1994, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Sofía",
                            TipoPersona = "Estudiante"
                        });
                });

            modelBuilder.Entity("Entities.Models.DireccionAcudiente", b =>
                {
                    b.Property<Guid>("DireccionAcudienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AcudienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CiudadLocalidad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ColoniaBarrio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EstadoProvincia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DireccionAcudienteId");

                    b.ToTable("DireccionAcudiente");

                    b.HasData(
                        new
                        {
                            DireccionAcudienteId = new Guid("fae3ad1c-7ec1-48db-874b-81a404003404"),
                            AcudienteId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Calle = "Calle 72",
                            CiudadLocalidad = "Bogotá",
                            CodigoPostal = "110231",
                            ColoniaBarrio = "Chapinero",
                            EstadoProvincia = "Bogotá D.C.",
                            Pais = "Colombia"
                        },
                        new
                        {
                            DireccionAcudienteId = new Guid("27cd64fb-fecb-43d1-a47c-a2d9c20846cc"),
                            AcudienteId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Calle = "Calle 72",
                            CiudadLocalidad = "Bogotá",
                            CodigoPostal = "110231",
                            ColoniaBarrio = "Chapinero",
                            EstadoProvincia = "Bogotá D.C.",
                            Pais = "Colombia"
                        },
                        new
                        {
                            DireccionAcudienteId = new Guid("7188955c-9894-41f2-a952-d68c195e03b6"),
                            AcudienteId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Calle = "Carrera 10",
                            CiudadLocalidad = "Bogotá",
                            CodigoPostal = "110321",
                            ColoniaBarrio = "La Candelaria",
                            EstadoProvincia = "Bogotá D.C.",
                            Pais = "Colombia"
                        },
                        new
                        {
                            DireccionAcudienteId = new Guid("8569a8d7-0ada-480b-bcac-5e50c8958f90"),
                            AcudienteId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Calle = "Avenida Boyacá",
                            CiudadLocalidad = "Bogotá",
                            CodigoPostal = "110511",
                            ColoniaBarrio = "Fontibón",
                            EstadoProvincia = "Bogotá D.C.",
                            Pais = "Colombia"
                        },
                        new
                        {
                            DireccionAcudienteId = new Guid("2df493e2-a7fb-4bf8-a80b-81f33e79711a"),
                            AcudienteId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Calle = "Calle 80",
                            CiudadLocalidad = "Bogotá",
                            CodigoPostal = "110841",
                            ColoniaBarrio = "Engativá",
                            EstadoProvincia = "Bogotá D.C.",
                            Pais = "Colombia"
                        },
                        new
                        {
                            DireccionAcudienteId = new Guid("be660767-5179-475e-9794-32ced91e80e1"),
                            AcudienteId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Calle = "Carrera 7",
                            CiudadLocalidad = "Bogotá",
                            CodigoPostal = "110171",
                            ColoniaBarrio = "Usaquén",
                            EstadoProvincia = "Bogotá D.C.",
                            Pais = "Colombia"
                        },
                        new
                        {
                            DireccionAcudienteId = new Guid("9bb56f72-213d-4af1-bcae-8f0050c3e04e"),
                            AcudienteId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Calle = "Avenida 68",
                            CiudadLocalidad = "Bogotá",
                            CodigoPostal = "110841",
                            ColoniaBarrio = "Kennedy",
                            EstadoProvincia = "Bogotá D.C.",
                            Pais = "Colombia"
                        });
                });

            modelBuilder.Entity("Entities.Models.EstudianteDocumentos", b =>
                {
                    b.Property<Guid>("EstudianteDocumentosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidatoEstudianteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroDocumento")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tamaño")
                        .HasColumnType("int");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstudianteDocumentosId");

                    b.ToTable("EstudianteDocumentos");

                    b.HasData(
                        new
                        {
                            EstudianteDocumentosId = new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"),
                            CandidatoEstudianteId = new Guid("c9d4c053-49b6-410c-bc78-2d54a999187f"),
                            Estado = true,
                            NombreDocumento = "Certificado de Nacimiento",
                            NumeroDocumento = 61464465,
                            Observaciones = "Ninguna",
                            Tamaño = 1024,
                            TipoDocumento = "Identificación",
                            Ubicacion = "ruta/al/documento1"
                        },
                        new
                        {
                            EstudianteDocumentosId = new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"),
                            CandidatoEstudianteId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Estado = true,
                            FechaActualizacion = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(292),
                            NombreDocumento = "Diploma",
                            NumeroDocumento = 987654,
                            Observaciones = "Logros académicos",
                            Tamaño = 2048,
                            TipoDocumento = "Educativo",
                            Ubicacion = "ruta/al/documento2"
                        },
                        new
                        {
                            EstudianteDocumentosId = new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"),
                            CandidatoEstudianteId = new Guid("4f3657e5-5824-47b8-b4cd-6f49a3f4dbf1"),
                            Estado = false,
                            FechaActualizacion = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(307),
                            NombreDocumento = "Certificado de Graduación",
                            NumeroDocumento = 123456,
                            Observaciones = "Graduación universitaria",
                            Tamaño = 1536,
                            TipoDocumento = "Educativo",
                            Ubicacion = "ruta/al/documento3"
                        },
                        new
                        {
                            EstudianteDocumentosId = new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"),
                            CandidatoEstudianteId = new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"),
                            Estado = true,
                            FechaActualizacion = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(310),
                            NombreDocumento = "Certificado de Matrícula",
                            NumeroDocumento = 789012,
                            Observaciones = "Matrícula escolar",
                            Tamaño = 8192,
                            TipoDocumento = "Educativo",
                            Ubicacion = "ruta/al/documento4"
                        },
                        new
                        {
                            EstudianteDocumentosId = new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"),
                            CandidatoEstudianteId = new Guid("31eb541a-9419-4eac-bf1b-0289a6c6f6f0"),
                            Estado = true,
                            FechaActualizacion = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(312),
                            NombreDocumento = "Cédula de Identidad",
                            NumeroDocumento = 555555,
                            Observaciones = "Documento oficial",
                            Tamaño = 4096,
                            TipoDocumento = "Identificación",
                            Ubicacion = "ruta/al/documento5"
                        },
                        new
                        {
                            EstudianteDocumentosId = new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"),
                            CandidatoEstudianteId = new Guid("7f255218-f8e0-45a9-9807-12e1bcfd438c"),
                            Estado = true,
                            FechaActualizacion = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(315),
                            NombreDocumento = "Carné de Estudiante",
                            NumeroDocumento = 7890123,
                            Observaciones = "Carné escolar",
                            Tamaño = 3072,
                            TipoDocumento = "Identificación",
                            Ubicacion = "ruta/al/documento6"
                        },
                        new
                        {
                            EstudianteDocumentosId = new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"),
                            CandidatoEstudianteId = new Guid("bb9b0679-4f04-4ac4-9ddc-5c3e50e81298"),
                            Estado = true,
                            FechaActualizacion = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(319),
                            NombreDocumento = "Boleta de Calificaciones",
                            NumeroDocumento = 9876543,
                            Observaciones = "Registro académico",
                            Tamaño = 5120,
                            TipoDocumento = "Educativo",
                            Ubicacion = "ruta/al/documento7"
                        },
                        new
                        {
                            EstudianteDocumentosId = new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"),
                            CandidatoEstudianteId = new Guid("a6509bea-688e-43b5-a870-6ee461ccf601"),
                            Estado = true,
                            FechaActualizacion = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(321),
                            NombreDocumento = "Pasaporte",
                            NumeroDocumento = 1234567,
                            Observaciones = "Documento de viaje",
                            Tamaño = 4096,
                            TipoDocumento = "Identificación",
                            Ubicacion = "ruta/al/documento8"
                        },
                        new
                        {
                            EstudianteDocumentosId = new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"),
                            CandidatoEstudianteId = new Guid("db9fcac5-8654-45c3-87c7-8b5e13e9e6c2"),
                            Estado = true,
                            FechaActualizacion = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(324),
                            NombreDocumento = "Certificado Médico",
                            NumeroDocumento = 543210,
                            Observaciones = "Informe médico",
                            Tamaño = 2048,
                            TipoDocumento = "Salud",
                            Ubicacion = "ruta/al/documento9"
                        },
                        new
                        {
                            EstudianteDocumentosId = new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"),
                            CandidatoEstudianteId = new Guid("b3b5a5a7-5b82-4f76-98c1-654589db8f61"),
                            Estado = true,
                            FechaActualizacion = new DateTime(2023, 9, 11, 23, 11, 31, 781, DateTimeKind.Local).AddTicks(326),
                            NombreDocumento = "Fotografía del Estudiante",
                            NumeroDocumento = 1111111,
                            Observaciones = "Foto de perfil",
                            Tamaño = 1024,
                            TipoDocumento = "Identificación",
                            Ubicacion = "ruta/al/documento10"
                        });
                });

            modelBuilder.Entity("Entities.Models.TelefonoAcudiente", b =>
                {
                    b.Property<Guid>("TelefonoAcudienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("AcudienteId")
                        .HasColumnType("int");

                    b.Property<string>("Indicativo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TelefonoAcudienteId");

                    b.ToTable("TelefonoAcudiente");

                    b.HasData(
                        new
                        {
                            TelefonoAcudienteId = new Guid("bb67f88d-4398-4683-a9f8-1f2a31491d58"),
                            AcudienteId = 1,
                            Indicativo = "+1",
                            Numero = -4135,
                            Tipo = "Móvil"
                        },
                        new
                        {
                            TelefonoAcudienteId = new Guid("f5fa2927-2833-4948-b0ae-f2c937e7f62c"),
                            AcudienteId = 2,
                            Indicativo = "+1",
                            Numero = -6975,
                            Tipo = "Móvil"
                        },
                        new
                        {
                            TelefonoAcudienteId = new Guid("af4c6a95-2e4d-459c-a894-7429479ea871"),
                            AcudienteId = 3,
                            Indicativo = "+1",
                            Numero = -5357,
                            Tipo = "Fijo"
                        },
                        new
                        {
                            TelefonoAcudienteId = new Guid("155f850c-8cba-4810-8718-eabb4254df85"),
                            AcudienteId = 4,
                            Indicativo = "+1",
                            Numero = -5753,
                            Tipo = "Móvil"
                        },
                        new
                        {
                            TelefonoAcudienteId = new Guid("37c25930-9abf-4a35-a690-035c82f7a3e5"),
                            AcudienteId = 5,
                            Indicativo = "+1",
                            Numero = 911,
                            Tipo = "Emergencia"
                        },
                        new
                        {
                            TelefonoAcudienteId = new Guid("80d8b3cd-494d-4485-8a01-ec7c70adff20"),
                            AcudienteId = 1,
                            Indicativo = "+1",
                            Numero = -667,
                            Tipo = "Móvil"
                        },
                        new
                        {
                            TelefonoAcudienteId = new Guid("7f65b603-3b9f-4d4f-a730-092917444e8e"),
                            AcudienteId = 2,
                            Indicativo = "+1",
                            Numero = -1889,
                            Tipo = "Móvil"
                        },
                        new
                        {
                            TelefonoAcudienteId = new Guid("c47a9f4f-11a6-4eb4-aecd-6e61d62f4b83"),
                            AcudienteId = 3,
                            Indicativo = "+1",
                            Numero = -3111,
                            Tipo = "Fijo"
                        },
                        new
                        {
                            TelefonoAcudienteId = new Guid("8da69459-418f-4546-ab99-70d48018b711"),
                            AcudienteId = 4,
                            Indicativo = "+1",
                            Numero = -4333,
                            Tipo = "Móvil"
                        },
                        new
                        {
                            TelefonoAcudienteId = new Guid("0dbf82f2-169e-48ba-88c1-5a4d107cb43a"),
                            AcudienteId = 5,
                            Indicativo = "+1",
                            Numero = -5555,
                            Tipo = "Emergencia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
