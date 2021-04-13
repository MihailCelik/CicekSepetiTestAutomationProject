Feature: Login
	Test otomasyon muhendisi olarak
	Login sayfasi kontrolleri yapilir.

	Scenario: SuccesLogin
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testotomasyon@gmail.com' yazılır
	* Password alanına 'Testlolaflora17.' yazılır
	* Sign In butonuna tıklanılır
	* LolaFlora ana sayfasına giriş yapıldığı görülür

	Scenario: FailLogin
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testlolaflora@gmail.com' yazılır
	* Password alanına 'Lolaflora10.' yazılır
	* Sign In butonuna tıklanılır
	* 'E-mail address or password is incorrect. Please check your information and try again.' pop-up geldiği görülür
	* Pop-up üzerindek Ok butonuna tıklanılır

    Scenario: EmptyEmailControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına ' ' yazılır
	* Password alanına 'Testlolaflora17.' yazılır
	* Sign In butonuna tıklanılır
	* Email alanında 'Required field.' uyarı mesajının geldiği görülür

	Scenario: EmptyPasswordControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testotomasyon@gmail.com' yazılır
	* Password alanına ' ' yazılır
	* Sign In butonuna tıklanılır
	* Password alanında 'Required field.' uyarı mesajının geldiği görülür

	Scenario: EmptyEmailAndPasswordControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına ' ' yazılır
	* Password alanına ' ' yazılır
	* Sign In butonuna tıklanılır
	* Email alanında 'Required field.' uyarı mesajının geldiği görülür
	* Password alanında 'Required field.' uyarı mesajının geldiği görülür

	Scenario: InvalidEmailAndEmptyPasswordControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testotomasyon' yazılır
	* Password alanına ' ' yazılır
	* Sign In butonuna tıklanılır
	* Email alanında 'Please enter a valid e-mail address.' uyarı mesajının geldiği görülür
	* Password alanında 'Required field.' uyarı mesajının geldiği görülür

	Scenario: InvalidEmailControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testotomasyon' yazılır
	* Password alanına 'Testlolaflora17.' yazılır
	* Sign In butonuna tıklanılır
	* Email alanında 'Please enter a valid e-mail address.' uyarı mesajının geldiği görülür

	Scenario: InvalidPasswordControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testotomasyon@gmail.com' yazılır
	* Password alanına 'Lolaflora10.' yazılır
	* Sign In butonuna tıklanılır
	* 'E-mail address or password is incorrect. Please check your information and try again.' pop-up geldiği görülür
	* Pop-up üzerindek Ok butonuna tıklanılır

	Scenario: ShowPasswordButtonControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testotomasyon@gmail.com' yazılır
	* Password alanına 'Testlolaflora17.' yazılır
	* Password alanının gizli olduğu görülür
	* Show Password butonuna tıklanır
	* Password alanının gizlenmediği görülür

	Scenario: ShortPasswordControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testotomasyon@gmail.com' yazılır
	* Password alanına 'Lo' yazılır
	* Sign In butonuna tıklanılır
	* Password alanında 'Please enter minimum 3 and maximum 20 characters.' uyarı mesajının geldiği görülür

	Scenario: LongPasswordControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testotomasyon@gmail.com' yazılır
	* Password alanına ''Lolaflora10.123456789' yazılır
	* Sign In butonuna tıklanılır
	* Password alanında 'Please enter minimum 3 and maximum 20 characters.' uyarı mesajının geldiği görülür

	Scenario: ShortPasswordAndInvalidEmailControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testotomasyon' yazılır
	* Password alanına 'Lo' yazılır
	* Sign In butonuna tıklanılır
	* Email alanında 'Please enter a valid e-mail address.' uyarı mesajının geldiği görülür
	* Password alanında 'Please enter minimum 3 and maximum 20 characters.' uyarı mesajının geldiği görülür

	Scenario: LongPasswordAndInvalidEmailControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* E-Mail alanına 'testotomasyon' yazılır
	* Password alanına ''Lolaflora10.123456789' yazılır
	* Sign In butonuna tıklanılır
	* Email alanında 'Please enter a valid e-mail address.' uyarı mesajının geldiği görülür
	* Password alanında 'Please enter minimum 3 and maximum 20 characters.' uyarı mesajının geldiği görülür

	Scenario: SuccesForgotPasswordControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* Forgot Password butonuna tıklanır
	* Mail alanına 'testotomasyon@gmail.com' yazılır
	* Send butonuna tıklanır 
	* 'You will receive an e-mail from us with instructions for resetting your password.' mesajı görülür

	Scenario: ForgotPasswordEmptyEmailControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* Forgot Password butonuna tıklanır
	* Mail alanına ' ' yazılır
	* Send butonuna tıklanır 
	* 'Required field.' mesajının geldiği görülür

	Scenario: ForgotPasswordInvalidEmailControl
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* Forgot Password butonuna tıklanır
	* Mail alanına 'testotomasyon' yazılır
	* Send butonuna tıklanır 
	* 'Please enter a valid e-mail address.' mesajının geldiği görülür

	Scenario: SignUp
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* Sign Up butonuna tıklanılır
	* Register sayfasının açıldığı görülür

	Scenario: LoginValidations
	* 'https://www.lolaflora.com/login' sitesine gidilir
	* Sign In sayfasının açıldığı görülür
	* 'Email' elementin bulunduğu görülür
	* 'Password' elementin bulunduğu görülür
	* 'Sign In' elementin bulunduğu görülür
	* 'Forgot Password' elementin bulunduğu görülür
	* 'Sign in with Facebook' elementin bulunduğu görülür
	* 'Sign Up' elementin bulunduğu görülür