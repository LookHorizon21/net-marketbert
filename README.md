# Proyecto ASP.NET Core MVC con Identity y Patrón Repositorio

Este es un proyecto desarrollado con **ASP.NET Core MVC**, utilizando **Identity con Razor Pages** para la autenticación y gestión de usuarios. Se ha implementado el **Patrón de Repositorio** para una mejor separación de responsabilidades y mantenimiento del código. Además, se ha organizado la aplicación utilizando **Areas** para modularizar el proyecto.

🚀 **Disponibilidad**

El proyecto está disponible en **GitHub** y también se ha desplegado en: **[http://devwed.tryasp.net/](http://devwed.tryasp.net/)**

## Tecnologías utilizadas

- **ASP.NET Core MVC**
- **Identity con Razor Pages**
- **Entity Framework Core**
- **SQL Server**
- **Patrón de Repositorio**
- **Areas en MVC**
- **Bootstrap y jQuery** (para la interfaz de usuario)

## Características principales

- Autenticación y gestión de usuarios con **Identity**
- Arquitectura basada en **Patrón de Repositorio**
- Uso de **Areas** para organizar módulos dentro de la aplicación
- CRUD de entidades con Entity Framework Core
- Bootstrap para un diseño responsivo y atractivo
- Despliegue en **http://devwed.tryasp.net/**

## Instalación y configuración

1. Clona el repositorio:
   ```bash
   git clone https://github.com/LookHorizon21/net-marketbert.git
   ```
2. Abre el proyecto en **Visual Studio**.
3. Restaura los paquetes NuGet:
   ```bash
   dotnet restore
   ```
4. Configura la cadena de conexión en `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "ConexionSQL": "Server=TU_SERVIDOR;Database=TU_BASE_DE_DATOS;User Id=TU_USUARIO;Password=TU_CONTRASEÑA;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=true"
   }
   ```
5. Aplica las migraciones a la base de datos:
   ```bash
   dotnet ef database update
   ```
6. Ejecuta la aplicación:
   ```bash
   dotnet run
   ```
7. Abre tu navegador en `http://localhost:5092/` (o el puerto correspondiente).

## Contribuciones

Si deseas contribuir a este proyecto, puedes hacer un **fork**, crear una rama y enviar un pull request.

1. Realiza un fork del repositorio.
2. Crea una nueva rama con tu función o corrección:
   ```bash
   git checkout -b feature/nueva-funcion
   ```
3. Realiza tus cambios y haz commit:
   ```bash
   git commit -m "Agregada nueva función"
   ```
4. Sube los cambios a tu repositorio:
   ```bash
   git push origin feature/nueva-funcion
   ```
5. Crea un Pull Request en GitHub.

## Contacto

Si tienes alguna duda o sugerencia, puedes contactarme en **aguerowedman@gmail.com**.

---

**Repositorio en GitHub:** [https://github.com/LookHorizon21/net-marketbert.git](https://github.com/LookHorizon21/net-marketbert.git)

