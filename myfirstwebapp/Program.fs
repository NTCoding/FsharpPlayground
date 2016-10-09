// Learn more about F# at http://fsharp.org

open System
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder

type Startup() = 
    member this.Configure(app: IApplicationBuilder) =
      app.Run(fun context -> context.Response.WriteAsync("Server running"))

[<EntryPoint>]
let main argv = 
    let host = WebHostBuilder().UseKestrel().UseStartup<Startup>().Build()
    host.Run()
    0
    
