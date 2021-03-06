using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using App.Areas.Identity.Data;

namespace App.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<Hoja_de_CotejoUser> _signInManager;
        private readonly UserManager<Hoja_de_CotejoUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        public RegisterModel(
            UserManager<Hoja_de_CotejoUser> userManager,
            SignInManager<Hoja_de_CotejoUser> signInManager,
            ILogger<RegisterModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }
        public class InputModel
        {

            public string ReturnUrl { get; set; }
            [Required]
            public string Codigo { get; set; }
            [Display(Name = "Nombre o nombres")]
            [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
            public string nombre { get; set; }
            [Display(Name = "Apellido Paterno")]
            [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
            public string apellidoPaterno { get; set; }
            [Display(Name = "Apellido Materno")]
            [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Caracteres no permitidos")]
            public string apellidoMaterno { get; set; }
            [Display(Name = "Tipo de Persona")]
            public string Persona { get; set; }
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

        }

        public string GeneratePassword(string nombre, string Codigo)
        {
            return nombre.Substring(0,3) + Codigo.Substring(0,3);
        }
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            Input.Password = GeneratePassword(Input.nombre, Input.Codigo);
            Input.Persona = "Administrator";
            if (ModelState.IsValid)
            {
                
                var user = new Hoja_de_CotejoUser
                {
                    UserName = Input.Codigo,
                    nombre = Input.nombre,
                    apellidoPaterno = Input.apellidoPaterno,
                    apellidoMaterno = Input.apellidoMaterno,
                    Persona = Input.Persona
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            // If we got this far, something failed, redisplay form
               return Page();
        }
    }
}