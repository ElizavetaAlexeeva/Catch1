mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, мир!");
    console.log("Привет, world!");
  },

  GiveMePlayerData: function () {
    
   myGameInstance.SendMessage('Yandex', 'SetName', player.getName());
  },

  
  

  ShowAdv: function(){
    ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
         if(wasShown==true) myGameInstance.SendMessage("MainMenu","AfterAds");
          console.log("----------adv was shown------");
           if(wasShown==false) myGameInstance.SendMessage("MainMenu","InsteadAds");
          // some action after close
        },
        onError: function(error) {
          myGameInstance.SendMessage("MainMenu","InsteadAds");
          // some action on error
        }
    }
})
  },

  SaveExtern: function(date) {
      var dateString = UTF8ToString(date);
      var myobj = JSON.parse(dateString);
      player.setData(myobj);
    },

    LoadExtern: function(){
      player.getData().then(_date => {
          const myJSON = JSON.stringify(_date);
          myGameInstance.SendMessage('Progress', 'SetPlayerInfo', myJSON);
      });
  },
});