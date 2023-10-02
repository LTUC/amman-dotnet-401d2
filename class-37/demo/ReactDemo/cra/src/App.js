import logo from './logo.svg';
import './App.css';
import React from 'react';

function App() {
  return (
    <main>
      <div className="App">
        <h2>Mood Application</h2>

        <MoodChange/>
      </div>

      <Footer message ="Thsi is the message"/>
    </main>
   
  );
}

function Footer(props){
  return(
    <footer>
      <small>This is from props {props.message}</small>
    </footer>
  )
}

class MoodChange extends React.Component{

  constructor(){
    super();
    this.state = {
      mood : 'neutral'
    }
  } 

  changeMoode(change){
    /// sad, neutral, happy
    let newMood = '';

    if(change === 'improve'){
        if(this.state.mood === 'sad'){
          newMood = 'neutral';
        }
        else{
          newMood ="happy"
        }
    }
    else{
      if(this.state.mood === 'happy'){
        newMood = 'neutral';
      }
      else{
        newMood ="sad"
      }
    }

    this.setState({mood : newMood})

  }

  render(){
    return(
      <>
      <button onClick={() => this.changeMoode("improve")}>Improve</button>
      <button onClick={() => this.changeMoode("worsen")}>Worsen</button>
      <h2>The Current Mode {this.state.mood}</h2>
      </>
    )
  }
}

export default App;
