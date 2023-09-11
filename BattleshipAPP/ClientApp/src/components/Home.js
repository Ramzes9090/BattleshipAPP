import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div>
            <h1>Battleship Game Application</h1>
            <br/>
            <p>This is a Battleship game simulator, based on one of the most popular games for two players. <br/>
                The history of the Battleship game dates back to the early 20th century. During that time, the game gained significant popularity.
                Today, there are numerous remakes and variants available. You can play this game physically or on your computer. The best thing about this game is that all you need to play is a pencil, paper, and a friend.   </p>
            
            <p>In my project, you can observe a simulation game between two computers. It is a full-stack web application. I used ASP .NET Core Web API for the backend, and for the frontend, I employed React.js. The project was mostly developed in C#. The primary focus of this project required using C# for the backend, where is all the logic. </p>
            <br></br>
            <h4>If you want to go to the simulator, click Game Page on the top of the right corner !!!</h4>
      </div>
    );
  }
}
