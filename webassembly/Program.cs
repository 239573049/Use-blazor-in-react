using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
// BlazorApp.Pages.Index可以修改成自己的渲染的razor组件
// my-blazor-counter就是上面提到的razor对应的标记 这样就可以在react通过my-blazor-counter去渲染BlazorApp.Pages.Index组件的内容了
builder.RootComponents.RegisterCustomElement<webassembly.Pages.Index>("my-blazor-counter");
builder.RootComponents.Add<HeadOutlet>("head::after");

await builder.Build().RunAsync();