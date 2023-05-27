//// notification.js

//const connection = new signalR.HubConnectionBuilder()
//    .withUrl("/notificationHub")
//    .build();

//connection.on("ReceiveMessage", (user, message) => {
//    // Logic to display the notification in your nav menu
//    // For example, update the notification count or append a new notification item
//    const notificationList = document.getElementById("notificationList");
//    const notificationCount = document.getElementById("notificationCount");

//    // Update the notification count
//    const currentCount = parseInt(notificationCount.textContent);
//    const newCount = currentCount + 1;
//    notificationCount.textContent = newCount;

//    // Append a new notification item
//    const notificationItem = document.createElement("div");
//    notificationItem.textContent = message;
//    notificationList.appendChild(notificationItem);
//});

//connection.start()
//    .then(() => {
//        console.log("Connected to the SignalR hub.");
//    })
//    .catch((err) => {
//        console.error(err);
//    });
// Create a connection to the SignalR hub
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/notificationHub")
    .build();

connection.on("ReceiveNotification", function (message) {
    // Handle the received notification, e.g., update the UI
    $('#notificationContainer').append('<div class="dropdown-item">' + message + '</div>');
    var notificationCount = parseInt($('#notificationCount').text()) + 1;
    $('#notificationCount').text(notificationCount);
});

// Start the SignalR connection
connection.start()
    .then(function () {
        console.log("SignalR connection established.");
    })
    .catch(function (error) {
        console.error(error);
    });

// Function to send a notification to a specific user
function sendNotificationToUser(userId, message) {
    connection.invoke("SendNotificationToUser", userId, message)
        .catch(function (error) {
            console.error(error);
        });
}
