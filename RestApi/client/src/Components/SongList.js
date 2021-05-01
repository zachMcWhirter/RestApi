import React, { useState, useEffect } from "react";
import Song from "./Song";


export default function SongList() {

    const [songs, setSongs] = useState([]);
    const [error, setError] = useState();

    useEffect(() => {
        fetch("https://localhost:44318/api/songs", {
            method: "GET",

        }).then(resp => resp.json())
            .then(setSongs)
            .catch(setError)
    }, [])


    return (
        <>
            <div>
                <h1>Song List</h1>
                {songs.map(s =>
                    <Song key={s.id} song={s}
                    />
                )}
            </div>
            <div>
                {error ? error.message : ""}
            </div>

        </>
    );

}