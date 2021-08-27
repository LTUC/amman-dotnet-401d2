import Link from 'next/link'

export default function Footer() {
    return (
        <footer className="p-4 mt-8 bg-gray-500 text-gray-50">
            <nav>
                <Link href="/careers">
                    <a>Careers</a>
                </Link>
            </nav>
        </footer>
    )
}
