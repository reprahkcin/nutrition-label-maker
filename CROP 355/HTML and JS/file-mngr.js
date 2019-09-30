

var unityInstance = UnityLoader.instantiate("unityContainer", "Build/NutritionFactsTrialBuild.json", { onProgress: UnityProgress });

function createImage(pngstring){
  $('#png').attr('src', `data:image/png;base64,${pngstring}`);
$('.pngwrapper').show();
  $('#unityContainer').hide();

  $('.footer').hide();


  console.log(pngstring)
}

function SayHello(arg) {
  $('#exampleModal').modal('show');
}


function SaySomethingToUnity(str) {
  unityInstance.SendMessage("MyObject", "MyFunction", str);
}

function bindForm() {
  $('#imageUploadForm').on('submit', (function (e) {
    e.preventDefault();

    var formData = new FormData(this);

    console.log(formData);

    $.ajax({
      type: 'POST',
      url: 'https://assets.oregonstate.education/v1/image',
      data: formData,
      cache: false,
      contentType: false,
      processData: false,
      success: function (data) {
        $('#exampleModal').modal('hide');
        console.log(data);
        SaySomethingToUnity(data.message.url);
      },
      error: function (data) {
        $('#exampleModal').modal('hide');
      }
    });
  }));
}



$(document).ready(function (e) {
  bindForm();
});
