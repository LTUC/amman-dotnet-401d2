import { useState } from 'react'
import Head from 'next/head'
import CreateForm from '../components/create-form'
import Header from '../components/header'
import Report from '../components/report'
import Footer from '../components/footer'

export default function Home() {

    const [report, setReport] = useState();

    function cookieStandCreateHandler(standInfo) {
        setReport(standInfo)
    }

    return (
        <div className="bg-green-50">
            <Head>
                <title>Cookie Stand Admin</title>
            </Head>
            <Header />
            <main className="py-8 text-center">
                <CreateForm onCreate={cookieStandCreateHandler} />
                <Report report={report} />
            </main>
            <Footer year="2021" />
        </div>
    )
}
