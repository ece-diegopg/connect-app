# connect-app
## Una app para visualizar productos y sus atributos, aplicando la arquitectura REST y el patron de repositorios con trasacciones.

## Frameworks y Librerias
### Backend:
- [ASP.NET Core 3.1](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-2.2);
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (ORM);
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle) (Documentacion de API).
### FrontEnd:
- [Angular](https://angular.io/docs) (Framework para SPAs).
- [Angular](https://material.angular.io/guide/getting-started) (Componentes Material Design).
## Infranstructura
- [Netlify](https://www.netlify.com/) (Servidor de static files-front-end).
- [azure](https://azure.microsoft.com) (Proveedor Cloud).
![Azure Stack](https://raw.githubusercontent.com/ece-diegopg/connect-app/master/images/azure.png)

## Probar
Navegar a ```https://connect-app-diegopg.netlify.app/products``` para probar la app desde el navegador.

Navegar a ```https://connect-backend.azurewebsites.net/swagger/index.html``` para la documentacion de la API.

![API Documentation](https://raw.githubusercontent.com/ece-diegopg/connect-app/master/images/swagger.png)
