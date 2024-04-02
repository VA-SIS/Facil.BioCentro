using Microsoft.AspNetCore.Builder;
using Facil.BioCentro;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<BioCentroWebTestModule>();

public partial class Program
{
}
