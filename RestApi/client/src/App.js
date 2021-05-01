import React from "react";
import { Switch, Route } from "react-router-dom";
import SongList from "./Components/SongList"
import './App.css';

function App() {
  return (
    <div>
      <Switch>
        <Route exact path="/" component={SongList} />
      </Switch>
    </div>
  );
}

export default App;
