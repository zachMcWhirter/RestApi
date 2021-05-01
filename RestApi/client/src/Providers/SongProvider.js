import React, { useState } from "react";

export const SongContext = React.createContext();

export const SongProvider = (props) => {

    const [songs, setSongs] = useState([]);
    const [song, setSong] = useState({});

    //Get all Tasks for all Users (for testing purposes)
    const getAllSongs = () => {
        fetch("/api/songs", {
            method: "GET"
        }).then(resp => resp.json())
            .then(setSongs);
    };

    return (
        <SongContext.Provider value={{
            songs, setSongs, song, setSong, getAllSongs,
        }}>
            {props.children}
        </SongContext.Provider>
    );
}
