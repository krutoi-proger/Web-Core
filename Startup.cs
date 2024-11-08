app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Calculator}/{action=Index}/{id?}");
});
// пашол наху ринат
