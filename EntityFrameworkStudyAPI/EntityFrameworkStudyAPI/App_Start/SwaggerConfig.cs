using System.Web.Http;
using Swashbuckle.Application;

public class SwaggerConfig
{
    public static void Register(HttpConfiguration config)
    {
        config.EnableSwagger(c =>
        {
            c.SingleApiVersion("v1", "EntityFrameworkStudy");
            // Adicione informações de documentação aqui
            c.IncludeXmlComments(GetXmlCommentsPath());
        })
        .EnableSwaggerUi(c =>
        {
            // Configure a interface do Swagger UI
        });
    }

    protected static string GetXmlCommentsPath()
    {
        return System.String.Format(@"{0}\bin\EntityFrameworkStudyAPI.XML", System.AppDomain.CurrentDomain.BaseDirectory);
    }
}