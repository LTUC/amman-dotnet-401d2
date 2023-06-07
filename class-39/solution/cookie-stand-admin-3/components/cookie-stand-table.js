import { hours } from '../data'

export default function CookieStandTable({ stands, onDelete }) {

    return (
        <Table>
            <thead>
                <tr className="bg-green-400">

                    <TH>Location</TH>
                    {hours.map(slot => (
                        <TH key={slot}>{slot}</TH>
                    ))}
                    <TH>Totals</TH>
                </tr>
            </thead>
            <tbody>
                {stands.map((stand, i) => {

                    return (
                        <tr className={i % 2 && "bg-green-300"} key={stand.id}>

                            <TH>
                                <div className="flex items-center justify-between gap-2 px-4">

                                    <p>{stand.location}</p>

                                    <svg onClick={() => onDelete(stand)} className="w-6 h-6 text-red-400 text-xsm" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M19 7l-.867 12.142A2 2 0 0116.138 21H7.862a2 2 0 01-1.995-1.858L5 7m5 4v6m4-6v6m1-10V4a1 1 0 00-1-1h-4a1 1 0 00-1 1v3M4 7h16" />
                                    </svg>
                                </div>
                            </TH>

                            {stand.cookiesEachHour.map((amt, i) => (
                                <TD key={i}>
                                    {amt}
                                </TD>
                            ))}
                            <TD>{stand.totalDailyCookies}</TD>
                        </tr>
                    )
                })}
            </tbody>
            <tfoot>
                <tr className="bg-green-400">
                    <TH>Totals</TH>
                    {hours.map((_, i) => {
                        const amt = stands.reduce((acc, cur) => acc + cur.cookiesEachHour[i], 0);
                        return <TD key={'amt' + i}>{amt}</TD>
                    })}
                    <TD>{stands.reduce((acc, cur) => acc + cur.totalDailyCookies, 0)}</TD>
                </tr>
            </tfoot>
        </Table>

    );
}

function Table({ children }) {
    return (
        <table className="w-full m-auto text-lg bg-green-200 border border-collapse border-green-800 rounded-lg">
            {children}
        </table>
    );
}
function TH({ children }) {
    return (
        <th className="p-1 text-left border border-green-600">{children}</th>
    )
}

function TD({ children }) {
    return (
        <td className="px-3 py-2 text-right border border-green-600">{children}</td>
    )
}
