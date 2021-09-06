import Head from 'next/head'
import styles from '../styles/Home.module.css'
import Layout from '../components/layout'
import { useState } from 'react'

export default function Home() {
    return (
        <Layout>
            <div className={styles.container}>
                <Head>
                    <title>Odometer</title>
                    <link rel="icon" href="/favicon.ico" />
                </Head>

                <Header text="The miles keep adding up" />
                <Odometer />
                <Footer copyright="2021" />
            </div>
        </Layout>
    )
}

function Header(props) {
    return (
        <>
            <h2>{props.text}</h2>
        </>
    )
}

function Odometer() {

    const [mileage, setMileage] = useState(0);

    function incrementMileage(amt) {
        const newMileage = (mileage + amt) % 10000;
        setMileage(newMileage);
    }

    function formatMileage() {
        const mileageText = String(mileage);
        return mileageText.padStart(4, "0");
    }

    return (
        <div>
            <p className={styles.mileage}>{formatMileage()}</p>
            <div className={styles.buttons}>
                <button onClick={() => incrementMileage(1)}>+ 1</button>
                <button onClick={() => incrementMileage(10)}>+ 10</button>
                <button onClick={() => incrementMileage(100)}>+ 100</button>
                <button onClick={() => incrementMileage(1000)}>+ 1000</button>
            </div>
        </div>
    )
}

function Footer(props) {
    return (
        <h2>&copy;{props.copyright}</h2>
    )
}
