"use strict"

class Message {
    constructor(username, text, when) {
        this.userName = username;
        this.text = text;
        this.when = when;
    }
}

var connection = new signalR.HubConnectionBuilder()
    .withUrl('/ChatHub')
    .build();
document.getElementById("submitButton").disabled = true;

const username = document.getElementById('username').value;
const textinput = document.getElementById('messageText');
const chat = document.getElementById('chat');
const userId = document.getElementsByClassName('userId');

connection.on('receiveMessage', function (message)  {
    let isCurrentUserMessage = message.userName === username;

    let container = document.createElement('div');
    container.className = isCurrentUserMessage ? "container darker" : "container";

    let sender = document.createElement('p');
    sender.className = "sender";
    sender.innerHTML = message.userName;
    let text = document.createElement('p');
    text.innerHTML = message.text;

    let when = document.createElement('span');
    when.className = isCurrentUserMessage ? "time-left" : "time-right";
    var currentdate = new Date();
    when.innerHTML =
        (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/"
        + currentdate.getFullYear() + " "
        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })

    container.appendChild(sender);
    container.appendChild(text);
    container.appendChild(when);
    chat.appendChild(container);
    textinput.value = "";
})

connection.start().then(function () {
    document.getElementById("submitButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById('submitButton').addEventListener('click', () => {

    var when = new Date();
    var message = new Message(username, textinput.value, when);
    var currentdate = new Date();
    message.user = userId;
    when.innerHtml =
        (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/"
        + currentdate.getFullYear() + " "
        + currentdate.toLocaleString('en-us', { hour: 'numeric', minute: 'numeric', hour12: true });

    connection.invoke("SendMessage", message);
    event.preventDefault();
});
