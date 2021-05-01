import React from "react";
import { Card, CardBody } from "reactstrap";

export default function Song({ song }) {




    return (

        // <div>
        //     {song.title}
        // </div>
        <Card className="card">
            <CardBody >
                <div>
                    <h2>{song.title}</h2>
                </div> 
                <div className="card-container">
                    <div className="card-details">

                        <p className="label"> {song.language} </p>
                    </div>
                    <div className="card-button-container">

                    </div>
                </div>
            </CardBody>
            <br />
        </Card>
    );
}
