import Link from 'next/link'

export default function CookieStandHeader({ username, onLogout }) {
    return (
        <header className="flex items-center justify-around bg-green-400">
            <h1 className="py-4 text-4xl font-bold text-center text-gray-800">
                Cookie Stand Admin
                </h1>
            <div className="flex gap-2 ">
                <p className="px-3 py-1 text-gray-800 bg-green-100 rounded-lg">{username}</p>
                <Link href="/">
                    <a onClick={onLogout} className="px-3 py-1 text-gray-100 bg-green-600 rounded-lg">Sign Out</a>
                </Link>
                <Link href="/overview">
                    <a className="px-3 py-1 text-gray-100 bg-green-600 rounded-lg">Overview</a>
                </Link>
            </div>
        </header>
    )
}
