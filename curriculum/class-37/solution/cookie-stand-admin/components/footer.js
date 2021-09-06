import React from 'react'

export default function Footer({ year }) {
    return (
        <footer className="p-4 bg-green-500">
            <p className="text-xl">&copy;{year}</p>
        </footer>
    )
}
