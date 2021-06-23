using System.Collections.Generic;
using GymTEC_API.DB;
using MongoDB.Bson;
using System.Security.Cryptography;
using System.Text;
using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace GymTEC_API.BasesDatos
{
    public class MongoDBConnection
    {

        private MongoClient cliente;
        private IMongoDatabase baseDatos;
        private IMongoCollection<UsuarioMongo> usuariosMongo;
        private int cont = 40;

        private string key = "BasesDatosMongo";

        public MongoDBConnection()
        {
            cliente = new MongoClient("mongodb://localhost:27017");
            baseDatos = cliente.GetDatabase("GymTEC");
            usuariosMongo = baseDatos.GetCollection<UsuarioMongo>("Usuarios");
        }

        public void insertarUsuario(Usuario usuario)
        {
            var documento = new UsuarioMongo{ _id = cont, numCedula = usuario.numCedula , contrasena = encriptarMD5(usuario.Password)};
            cont++;
            usuariosMongo.InsertOne(documento);
        }
        public void EliminarUsuario(Usuario usuario)
        {
            var filter = Builders<UsuarioMongo>.Filter.Eq(e => e.numCedula, usuario.numCedula);
            usuariosMongo.DeleteOne(filter);
        }
        public void EditarUsuario(Usuario usuario)
        {
            var filter = Builders<UsuarioMongo>.Filter.Eq(e => e.numCedula, usuario.numCedula);
            var update = Builders<UsuarioMongo>.Update.Set("contrasena", encriptarMD5(usuario.Password));
            usuariosMongo.UpdateOne(filter,update);
        }

        public IList<UsuarioMongo> obtenerDatosMongo()
        {
            return usuariosMongo.Find(_ => true).ToList();
        }
        
        public void insertarEmpleado(Empleado usuario)
        {
            
            var documento = new UsuarioMongo{ _id = cont, numCedula = usuario.numCedula , contrasena = encriptarMD5(usuario.Password)};
            cont++;
            usuariosMongo.InsertOne(documento);
        }
        public void EliminarEmpleado(Empleado usuario)
        {
            var filter = Builders<UsuarioMongo>.Filter.Eq(e => e.numCedula, usuario.numCedula);
            usuariosMongo.DeleteOne(filter);
        }
        public void EditarEmpleado(Empleado usuario)
        {
            var filter = Builders<UsuarioMongo>.Filter.Eq(e => e.numCedula, usuario.numCedula);
            var update = Builders<UsuarioMongo>.Update.Set("contrasena", encriptarMD5(usuario.Password));
            usuariosMongo.UpdateOne(filter,update);
        }
        
        
        //Encriptar to MD5
        
        public string encriptarMD5(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }
        public string desencriptarMD5(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }



    }



    [BsonIgnoreExtraElements]
    public class UsuarioMongo
    {
        [BsonElement("_id")] 
        public int _id { get; set; }

        [BsonElement("numCedula")] 
        public int numCedula { get; set; }
        
        [BsonElement("contrasena")] 
        public string contrasena { get; set; }

    }
    
}