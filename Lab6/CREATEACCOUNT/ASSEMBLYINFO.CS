using System.Reflection;
using System.Runtime.CompilerServices;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
// Общая информация о сборке контролируется с помощью следующего набора атрибутов. 
// Измените значения этих атрибутов, чтобы изменить информацию, связанную со сборкой.
//
[assembly:AssemblyTitle("")]
[assembly:AssemblyDescription("")]
[assembly:AssemblyConfiguration("")]
[assembly:AssemblyCompany("")]
[assembly:AssemblyProduct("")]
[assembly:AssemblyCopyright("")]
[assembly:AssemblyTrademark("")]
[assembly:AssemblyCulture("")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Revision
//      Build Number
//
// You can specify all the value or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

// Информация о версии для сборки состоит из следующих четырех значений:
//
//      Основная версия
//      Дополнительная версия
//      Ревизия
//      Номер сборки
//
// Вы можете указать все значения или можете использовать номера ревизии и сборки по умолчанию
// с помощью '*', как показано ниже:

[assembly:AssemblyVersion("1.0.*")]

//
// In order to sign your assembly you must specify a key to use. Refer to the 
// COM+ 2.0 documentation for more information on assembly signing.
//
// Use the attributes below to control which key is used for signing. 
//
// Notes: 
//   (*) If no key is specified - the assembly cannot be signed.
//   (*) KeyName refers to a key that has been installed in the Crypto Service
//       Provider (CSP) on your machine. 
//   (*) If the key file and a key name attributes are both specified, the 
//       following processing occurs:
//       (1) If the KeyName can be found in the CSP - that key is used.
//       (2) If the KeyName does not exist and the KeyFile does exist, the key 
//           in the file is installed into the CSP and used.
//   (*) Delay Signing is an advanced option - see the COM+ 2.0 documentation for 
//       more information on this.
//
// Чтобы подписать сборку, необходимо указать ключ для использования. Дополнительную информацию о подписи сборок см. в документации COM+ 2.0.
//
// Используйте атрибуты ниже для управления тем, какой ключ используется для подписи.
//
// Примечания:
// (*) Если ключ не указан, сборку нельзя подписать.
// (*) KeyName относится к ключу, который установлен в поставщике
//     криптослужбы (CSP) на вашем компьютере.
// (*) Если указаны оба атрибута файла ключа и имени ключа, выполняется следующая обработка:
//     (1) Если KeyName можно найти в CSP, используется этот ключ.
//     (2) Если KeyName не существует, а KeyFile существует, ключ
//     в файле устанавливается в CSP и используется.
// (*) Отложенная подпись — это расширенная опция, дополнительную информацию об
//     этом см. в документации COM+ 2.0.
[assembly:AssemblyDelaySign(false)]
[assembly:AssemblyKeyFile("")]
[assembly:AssemblyKeyName("")]
