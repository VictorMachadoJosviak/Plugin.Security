<img align="left" src="https://i.imgur.com/t4P3Rra.png" width="100" height="100"> 

# Plugin.Security

Nuget Install-Package Plugin.Security -Version 1.0.2

Example:

```
 static void Main(string[] args)
 {
      PasswordEncoder encoder = new PasswordEncoder();

      var user = "name@example.com";
      var pwd = "1234";
      var salt = encoder.DefaultSalt[36];

      var result = encoder.Encode(salt + user + pwd, EncryptType.SHA_512);

      Console.WriteLine(result);            
      Console.ReadKey();
}
 
```
