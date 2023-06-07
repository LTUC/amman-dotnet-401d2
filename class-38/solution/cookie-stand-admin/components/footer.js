export default function Footer({ reports }) {
    return (
        <footer className="p-4 text-xl text-gray-800 bg-green-500">
            <p>{reports.length} Locations World Wide</p>
        </footer>
    )
}
