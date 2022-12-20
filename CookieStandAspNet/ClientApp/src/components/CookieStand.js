import React, { Component } from 'react';
import axios from "axios";

export class CookieStand extends Component {
    static displayName = CookieStand.name;

    constructor(props) {
        super(props);
        this.state = {
            info : []
            /*id: "",
            minCus: "",
            maxCus: "",
            location: "",
            average_cookies_per_sale: "",
            description: "",
            owner: ""*/
        };
    }

    cookie = async (e) => {
        e.preventDefault();
        // user search goes here
        const API = `https://localhost:7143/api/cookiestand`;
        //  third party api
        try {
            let res = await axios.get(API);
            this.setState(
                {
                    info: res.data
                    /*id: res.data[0].Id,
                    minCus: res.data[0].minimum_customers_per_hour,
                    maxCus: res.data[0].maximum_customers_per_hour,
                    location: res.data[0].location,
                    average_cookies_per_sale: res.data[0].average_cookies_per_sale,
                    description: res.data[0].description,
                    owner: res.data[0].owner,*/
                },
                console.log(res.data)
            );
        } catch (error) {
            alert("Error something went wrong, Data not found", error);
        }
    };

    render() {
        return (
            <div>
                <h1>CookieStand</h1>
                {this.state.info.map((cookies) => (
                    <ul key={cookies.id}>
                        <li >MinCus: {cookies.minimum_customers_per_hour}</li>
                        <li >MaxCus: {cookies.maximum_customers_per_hour}</li>
                        <li >Location: {cookies.location}</li>
                        <li >Average: {cookies.average_cookies_per_sale}</li>
                        <li >DEscription: {cookies.description}</li>
                        <li >Owner: {cookies.owner}</li>
                    </ul>

                ))}
                <button className="btn btn-primary" onClick={this.cookie}>Cookie Data</button>
            </div>


        );
    }
}