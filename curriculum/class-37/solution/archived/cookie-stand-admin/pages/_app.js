import '../styles/globals.css'
import { useState } from 'react'
import { getTokens } from '../services/data-fetcher'
import LoginForm from '../components/login-form'



function MyApp({ Component, pageProps }) {

    const [tokens, setTokens] = useState();

    const [username, setUsername] = useState('');

    const [loading, setLoading] = useState(false);

    async function loginHandler(values) {

        setLoading(true);

        const fetchedTokens = await getTokens(values);

        setTokens(fetchedTokens);

        setUsername(values.username);

        setLoading(false);
    }

    function logoutHandler() {
        setTokens(null);
    }

    if (loading) return <h1>Authenticating...</h1>
    if (!tokens) return <LoginForm onSubmit={loginHandler} />


    return <Component {...pageProps} tokens={tokens} username={username} onLogin={loginHandler} onLogout={logoutHandler} />
}

export default MyApp
