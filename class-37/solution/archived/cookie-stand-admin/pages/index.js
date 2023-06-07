import CookieStandAdmin from '../components/cookie-stand-admin'


export default function Home({ tokens, username, onLogout, onLogin }) {

    return <CookieStandAdmin
        tokens={tokens}
        onLogout={onLogout}
        username={username}
    />
}


