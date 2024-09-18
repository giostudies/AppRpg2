using AppRpgEtec.ViewModels.Usuarios;

namespace AppRpgEtec.Views.Usuarios;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		UsuarioViewModel _usuarioViewModel;

		InitializeComponent();
        _usuarioViewModel = new UsuarioViewModel();
		BindingContext = _usuarioViewModel;


    }
}