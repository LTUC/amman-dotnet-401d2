import Head from 'next/head'
import { useState } from 'react'
import ReportTable from '../components/report-table'
import CreateForm from '../components/create-form'
import Header from '../components/header'
import Footer from '../components/footer'

export default function CookieStandAdmin() {

    const [report, setReport] = useState();

    function createHandler(standData) {
        setReport(standData);
    }

    return (
        <div className="min-h-screen bg-green-50">
            <Head>
                <title>Cookie Stand Admin</title>
                <link rel="icon" href="/favicon.ico" />
            </Head>

            <Header title={"Cookie Stand Admin"} />

            <main className="p-8">

                <CreateForm onCreate={createHandler} />

                <ReportTable report={report} />

            </main>

            <Footer copyright={2021} />
        </div>
    )
}
