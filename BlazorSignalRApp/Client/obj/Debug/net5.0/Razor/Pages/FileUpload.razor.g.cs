#pragma checksum "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d61e64fa5cfa3c6ea16850b29b5bfc0fa520b84"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSignalRApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/_Imports.razor"
using BlazorSignalRApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/_Imports.razor"
using BlazorSignalRApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FileUpload")]
    public partial class FileUpload : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>File Upload Component</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 10 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
                       editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
                                                   OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\n        Name: ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
                                       person.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.Name = __value, person.Name))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        ");
                __Blazor.BlazorSignalRApp.Client.Pages.FileUpload.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 15 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
                                () => person.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "\n        Picture: ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(22);
                __builder2.AddAttribute(23, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 19 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
                                      OnChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n        ");
                __Blazor.BlazorSignalRApp.Client.Pages.FileUpload.TypeInference.CreateValidationMessage_1(__builder2, 26, 27, 
#nullable restore
#line 20 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
                                () => person.Picture

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 22 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
          
            var progressCss = "progress " + (displayProgress ? "" : "d-none");
            var progressWidthStyle = progressPercent + "%";
        

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", 
#nullable restore
#line 27 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
                     progressCss

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "progress-bar");
                __builder2.AddAttribute(32, "role", "progressbar");
                __builder2.AddAttribute(33, "style", "width:" + (
#nullable restore
#line 28 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
                                                                       progressWidthStyle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "area-valuenow", 
#nullable restore
#line 28 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
                                                                                                           progressPercent

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(35, "aria-minvalue", "0");
                __builder2.AddAttribute(36, "aria-maxvalue", "100");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n\n    ");
                __builder2.AddMarkupContent(38, "<button>Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/Users/Luce/Projects/practice-blazor/BlazorSignalRApp/Client/Pages/FileUpload.razor"
 
    private CancellationTokenSource cancelation;
    private bool displayProgress;
    private EditContext editContext;
    private Person person;
    private int progressPercent;

    protected override void OnInitialized()
    {
        cancelation = new CancellationTokenSource();
        person = new Person();
        editContext = new EditContext(person);
    }

    private void OnChange(InputFileChangeEventArgs eventArgs)
    {
        person.Picture = eventArgs.File;
        editContext.NotifyFieldChanged(FieldIdentifier.Create(() => person.Picture));
    }

    private async Task OnSubmit()
    {
        using var file = File.OpenWrite(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
        using var stream = person.Picture.OpenReadStream();

        var buffer = new byte[4 * 1096];
        int bytesRead;
        double totalRead = 0;

        displayProgress = true;

        while ((bytesRead = await stream.ReadAsync(buffer, cancelation.Token)) != 0)
        {
            totalRead += bytesRead;
            await file.WriteAsync(buffer, cancelation.Token);

            progressPercent = (int)((totalRead / person.Picture.Size) * 100);
            StateHasChanged();
        }

        displayProgress = false;
    }

    public void Dispose()
    {
        cancelation.Cancel();
    }

    public class Person
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; } = "Pranav";

        [Required]
        [FileValidation(new[] { ".png", ".jpg" })]
        public IBrowserFile Picture { get; set; }
    }

    private class FileValidationAttribute : ValidationAttribute
    {
        public FileValidationAttribute(string[] allowedExtensions)
        {
            AllowedExtensions = allowedExtensions;
        }

        private string[] AllowedExtensions { get; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = (IBrowserFile)value;

            var extension = System.IO.Path.GetExtension(file.Name);

            if (!AllowedExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase))
            {
                return new ValidationResult($"File must have one of the following extensions: {string.Join(", ", AllowedExtensions)}.", new[] { validationContext.MemberName });
            }

            return ValidationResult.Success;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorSignalRApp.Client.Pages.FileUpload
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
