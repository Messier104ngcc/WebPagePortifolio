
// Obtém a URL atual  
const currentPath = window.location.pathname;

// Obtem todos os links de navegação  
const navLinks = document.querySelectorAll('.nav');

navLinks.forEach(link => {
    // Compara o nome do arquivo na URL atual com o href do link  
    const linkPath = link.getAttribute('href');

    if (linkPath === currentPath) {
        link.classList.add('active'); // Adiciona a classe 'active' apenas ao link correto  
    } else {
        link.classList.remove('active'); // Remove 'active' de outros links  
    }
});
