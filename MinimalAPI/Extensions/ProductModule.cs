using System;
using Carter;

namespace MinimalAPI.Extensions;

// public static class ProductModule
// {
//     public static void MapProducts(this IEndpointRouteBuilder app)
//     {

//         var group = app.MapGroup("api/products").RequireAuthorization().RequireRateLimiting("fixed");

//         group.MapGet(string.Empty, () =>
//         {
//             return Results.Ok(Guid.CreateVersion7());
//         }).Produces<Guid>();

//         group.MapPost(string.Empty, () =>
//         {
//             return Results.Ok(Guid.CreateVersion7());
//         });
//     }
// }
public class ProductModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
       var group = app.MapGroup("api/products").RequireAuthorization().RequireRateLimiting("fixed");

        group.MapGet(string.Empty, () =>
        {
            return Results.Ok(Guid.CreateVersion7());
        }).Produces<Guid>();

        group.MapPost(string.Empty, () =>
        {
            return Results.Ok(Guid.CreateVersion7());
        });
    }
}