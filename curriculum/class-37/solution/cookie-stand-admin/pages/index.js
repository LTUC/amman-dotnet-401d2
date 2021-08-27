import Head from 'next/head'
import { useState } from 'react'
import { hours } from '../data'
import ReportTable from '../components/report-table'
import CreateForm from '../components/create-form'
import Header from '../components/header'
import Footer from '../components/footer'

export default function CookieStandAdmin() {

    const [standReports, setStandReports] = useState([]);

    function createHandler(standData) {
        setStandReports([...standReports, standData]);
    }

    return (
        <div className="min-h-screen bg-green-50">
            <Head>
                <title>Cookie Stand Admin</title>
                <link rel="icon" href="/favicon.ico" />
            </Head>

            <Header />

            <main className="p-8">

                <CreateForm onCreate={createHandler} />

                <ReportTable hours={hours} reports={standReports} />

            </main>

            <Footer reports={standReports} />
        </div>
    )
}
