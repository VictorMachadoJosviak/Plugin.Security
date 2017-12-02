using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Plugin.Security.Core
{
    public class PasswordEncoder
    {
        /// <summary>
        /// generate hash
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Encode(string password)
        {
            try
            {
                var encodedValue = Encoding.UTF8.GetBytes(password);

                var hash = SHA512.Create().ComputeHash(encodedValue);

                var sb = new StringBuilder();
                
                foreach (var item in hash)
                {
                    sb.Append(item.ToString("X2"));
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get a ramdom salt
        /// </summary>
        public string RandomSalt
        {
            get
            {
                return Guid.NewGuid().ToString();
            }
        }

        /// <summary>    
        ///  pass the position of the array to pick up a constant salt DefaultSalt[5] total array salt = 36
        /// </summary>
        public string[] DefaultSalt
        {
            get
            {
                var guids = "03a7174c-6b73-4b7c-8a34-6ec45a623261;" +
                            "277b6d79-b5df-4026-81b4-4f5d6e513228;" +
                            "51a7a066-a2a8-4886-b0c6-21a67d5df667;" +
                            "2b7b424d-e3f7-4d87-bbe3-7535694334e5;" +
                            "087cb12d-b84a-4198-b358-a2661b751f09;" +
                            "4cfdcb49-5e08-4f85-9305-08bd27673933;" +
                            "6f9db921-e47d-4b41-9385-83e7b0fac0f7;" +
                            "c435b3f5-f987-448a-b19f-2a7a22c7bc3f;" +
                            "e1b0f01f-a7e0-48d0-9c15-6622327d724d;" +
                            "348578c8-c392-4e09-9b16-253969822645;" +
                            "edd96135-f90e-4369-a9d4-f1808ba964ef;" +
                            "20a4b9ac-79e1-4ddd-8317-14959b4f659e;" +
                            "e6401578-abdf-4183-8f7e-6924ac15166d;" +
                            "c342ac48-76c9-4c98-8d7e-06a0a8555d0d;" +
                            "5f1fd41e-3b86-4164-b3b5-ef77f38203ed;" +
                            "a0d0c3d9-dc6d-42a3-9551-d8d6c758277c;" +
                            "adfd6709-bfd9-45fd-860e-369103144eb2;" +
                            "f68bef4b-895c-48ee-a72d-10dede6cafd0;" +
                            "0236de1e-f1ae-4c48-9eed-33617675e633;" +
                            "528575ce-018b-4aa5-b848-493a13e6c7ce;" +
                            "3c3a1d09-feb1-42ac-a694-afb2d4c88fcb;" +
                            "dd4fc7a0-8a3a-4fd5-9133-8d3557a6bded;" +
                            "9c61d49d-22eb-4d8b-a162-87e954dbc459;" +
                            "81a03a23-d82f-4775-bd75-f573770995b9;" +
                            "b28028b7-de91-42e5-9491-50c5daa25b45;" +
                            "9442f5d7-e175-4e1d-8a71-e1a812449795;" +
                            "4f48c25c-9572-4c6e-a76c-4d7b11f3f267;" +
                            "5c57eb90-dcf4-470c-b993-5542aba0c20a;" +
                            "a812c451-87f2-43cd-9372-47dc2c667d0c;" +
                            "fe44252a-a336-40a9-8000-b91b4f8090f3;" +
                            "c769da00-2e1f-4a56-8ffe-566c37e84e46;" +
                            "02ccde04-6cff-46c2-8d28-fdd26a80712b;" +
                            "92bb130f-5d3d-460f-bace-e29b2c2430dc;" +
                            "091bc1e4-16f6-4bec-9ec3-34885e54921d;" +
                            "ec6b4d14-3b49-4fd3-ae72-02e6e55ce86e;" +
                            "6fb71031-a43f-40f7-aba6-82d11bf8f6e1;";


                return guids.Split(';');
            }
        }

    }
}
