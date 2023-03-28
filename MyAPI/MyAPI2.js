$(document).ready(function () {
    $("#savebtton").click(function () {
      // debugger;
    //   var taskId = $("#taskId").val();
      var title = $("#title").val();
      var description = $("#description").val();
      var scheduleDate = $("#scheduleDate").val();
      var isCompleted = $("#isCompleted").val();
  
      $.ajax({
        url: "https://localhost:7180/api/ToDo",
        method: "POST",
        dataType: "json",
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
        data: JSON.stringify({
            // taskId: taskId,
            title: title,
          description: description,
          scheduleDate:scheduleDate,
          isCompleted:isCompleted
        }),
        success: function (data, status, xhr) {
          // success callback function
          $("p").append(
            "title: " + data.title + " " + " " + "Department: " + data.description+ " " +"Date: " + data.scheduleDate+ " "+"Status:" + data.isCompleted
          );
        },
        error: function (request, status, error) {
          alert("Error: " + request.responseText);
        },
      });
    });
  });