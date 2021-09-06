import styles from './layout.module.css'
import Link from 'next/link'

export default function Layout({ children }) {
    return (
        <div>
            <nav className={styles.nav}>
                <Link href="/">
                    <a>Home</a>
                </Link>
                <Link href="/about">
                    <a>About</a>
                </Link>
            </nav>
            <main className={styles.container}>
                {children}
            </main>
        </div>
    )
}
