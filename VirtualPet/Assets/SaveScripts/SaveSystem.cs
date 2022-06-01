using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem{

public static void SavePet(StatusScript status, ChoosingSprite sprite, PetMovement move, DecorButton decor){
    BinaryFormatter formatter = new BinaryFormatter();
    string path = Application.persistentDataPath + "/pet.save";

    FileStream stream = new FileStream(path, FileMode.Create);
    PetData data = new PetData(status, sprite, move, decor);

    formatter.Serialize(stream,data);
    stream.Close();
}
  

  public static PetData loadPet(){
      string path = Application.persistentDataPath + "/pet.save";
      if(File.Exists(path)){
          BinaryFormatter formatter = new BinaryFormatter();
          FileStream stream = new FileStream (path, FileMode.Open);
          
          PetData data = formatter.Deserialize(stream) as PetData;
        
            stream.Close();
          return data;
        }else{
          Debug.LogError("Save file not found");
          return null;
      }

  }
}
