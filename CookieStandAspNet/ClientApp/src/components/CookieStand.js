import React, { useState, useEffect } from 'react';
import axios from "axios";
import Data from "./Data";

export default function CookieStand() {

    const [location, setLocation] = useState("");
    const [min, setMin] = useState(0);
    const [max, setMax] = useState(0);
    const [average, setAverage] = useState(0);
    const [stands, setStands] = useState("");

    const handleSubmit = async (e) => {
        e.preventDefault();
        const url = "https://localhost:7143/api/cookiestand";

        const newStand = {
            location,
            Minimum_Customers_Per_Hour: parseInt(min),
            Maximum_Customers_Per_Hour: parseInt(max),
            Average_Cookies_Per_Sale: parseInt(average)
        }
        try {
            await axios.post(url, newStand)
            getData();
        } catch (error) {
            console.log(error);
            console.log(error.message);
        }
        setLocation("");
        setAverage(0);
        setMin(0);
        setMax(0);
    }

    const getData = async () => {
        const url = "https://localhost:7143/api/cookiestands";
        try {
            var response = await axios.get(url);
            setStands(response.data);
            console.log(response.data);
        } catch (error) {
            console.log(error);
            console.log(error.message);
        }
    }

    useEffect(() => {
        getData();
    }, []);

    return (
        <>
            <form onSubmit={(e) => handleSubmit(e)} style={{ display: "grid", gridTemplateColumns: "repeat(4, 1fr)", gridTemplateRows: "repeat(3, 1fr)", columnGap: "1rem", rowGap: "1.5rem", backgroundColor: "#6FE6B7", padding: "1rem", borderRadius: "1%/5%" }}>
                <div style={{ gridRow: "1/2", gridColumn: "1/5" }}>
                    <h1 style={{ fontSize: "40px", textAlign: "center" }}>Create Cookie Stand</h1>
                </div>

                <div style={{ gridRow: "2/3", gridColumn: "1/5" }} class="form-group">
                    <label for="location">Location</label>
                    <input value={location} onChange={(e) => setLocation(e.target.value)} type="text" class="form-control" id="location" placeholder="Enter location" />
                </div>

                <div style={{ gridRow: "3/4", gridColumn: "1/2" }} class="form-group">
                    <label for="minimum_customers_per_hour">Minimum Customers Per Hour</label>
                    <input value={min} onChange={(e) => setMin(e.target.value)} type="number" class="form-control" id="minimum_customers_per_hour" />
                </div>

                <div style={{ gridRow: "3/4", gridColumn: "2/3" }} class="form-group">
                    <label for="maximum_customers_per_hour">Maximum Customers Per Hour</label>
                    <input value={max} onChange={(e) => setMax(e.target.value)} type="number" class="form-control" id="maximum_customers_per_hour" />
                </div>

                <div style={{ gridRow: "3/4", gridColumn: "3/4" }} class="form-group">
                    <label for="average_cookies_per_sale">Average Cookies Per Sale</label>
                    <input value={average} onChange={(e) => setAverage(e.target.value)} type="number" class="form-control" id="average_cookies_per_sale" />
                </div>

                <button style={{ gridRow: "3/4", gridColumn: "4/5", backgroundColor: "#15B981", fontSize: "30px" }}>Create</button>
            </form>


            {stands != "" && <Data stands={stands} />}
        </>
    )
    }