import React, { useContext, useEffect } from "react";
import { SongContext } from "../Providers/SongProvider";
import Song from "./Song";

export default function SongList() {
    const { songs, getAllSongs } = useContext(SongContext);

    useEffect(() => {
        getAllSongs()
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

        </>
    );

}