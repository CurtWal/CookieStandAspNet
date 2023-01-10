import React from 'react';

export default function Data({ stands }) {
    return (
        <>
            <h2 style={{ fontSize: "15px", textAlign: "center" }}>Cookie Stands</h2>
            {stands.map(x => <p key={x.Id}>Location: {x.location}, Minimum Customers Per Hour: {x.minimum_Customers_Per_Hour}, Maximum Customers Per Hour: {x.maximum_Customers_Per_Hour}, Average Cookies Per Sale: {x.average_Cookies_Per_Sale} </p>)}
        </>
    )
};